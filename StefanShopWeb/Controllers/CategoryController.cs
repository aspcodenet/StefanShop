using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StefanShopWeb.Infrastructure;
using StefanShopWeb.Models;

namespace StefanShopWeb.Controllers
{
    public class CategoryController : ShopBaseController
    {
       
        public ActionResult View(int id)
        {
            using (var context = new Models.Model1())
            {
                //InitializeLayoutModels(context);

                var model = new ViewModels.CategoryPageViewModel();
                model.CategoryMenuViewModel = CreateCategoryMenu(context);
                var category = GetCategory(context, id);
                model.CurrentCategoryId = category.Id;
                model.CurrentCategoryName = category.Name;
                model.Products = ConvertProducts(category.Products).ToList();
                return View(model);
            }
        }


        private Models.Category GetCategory(Model1 context, int id)
        {
            return context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}