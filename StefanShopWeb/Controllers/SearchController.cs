using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StefanShopWeb.Controllers
{
    public class SearchController : ShopBaseController
    {
        public ActionResult Deals()
        {
            using (var context = new Models.Model1())
            {
                var model = new ViewModels.DealsPageViewModel();
                base.InitializeLayoutModels(context);
                model.CategoryMenuViewModel = CreateCategoryMenu(context);
                model.Products = ConvertProducts(context.Products.Where(
                    p=>p.CampaignPrice != 0
                    ).OrderByDescending(pr=>pr.CampaignPrice / pr.Price)).ToList();
                return View(model);
            }

        }
    }
}