using StefanShopWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StefanShopWeb.Controllers
{
    public class HomeController : ShopBaseController
    {
        public ActionResult Index()
        {
            using (var context = new Models.Model1())
            {
                InitializeLayoutModels(context);

                var model = new StartPageViewModel();
                model.CategoryMenuViewModel = CreateCategoryMenu(context);
                model.FirstPageProduct = GetFirstPageProduct(context);
                return View(model);
            }
        }

        public StartPageViewModel.FirstPageProductViewModel GetFirstPageProduct(Models.Model1 context)
        {
            var product = context.Products.Where(r => r.CampaignPrice > 0)
                .ToList().Select(r=>new StartPageViewModel.FirstPageProductViewModel {
                    HeaderText = "",
                    Name  = r.Name,
                    Id = r.ProductKey,
                    PriceBefore = r.Price.ToString(),
                    PriceNow = r.CampaignPrice.ToString()
                }).OrderBy(r => Guid.NewGuid()).First();
            product.HeaderText = "Special deal";
            return product;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}