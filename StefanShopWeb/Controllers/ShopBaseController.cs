using StefanShopWeb.Infrastructure;
using StefanShopWeb.Models;
using StefanShopWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StefanShopWeb.Controllers
{
    public class ShopBaseController : Controller
    {

        protected void InitializeLayoutModels(Models.Model1 context)
        {
            ViewBag.TopMenuViewModel = new StefanShopWeb.ViewModels.TopMenuViewModel
            {
                Items = CreateTopMenuItenms(context).ToList()
            };
        }

        private IEnumerable<TopMenuItemViewModel> CreateTopMenuItenms(Model1 context)
        {
            string action = System.Web.HttpContext.Current.Request.RequestContext.RouteData.GetRequiredString("action");
            string controller = System.Web.HttpContext.Current.Request.RequestContext.RouteData.GetRequiredString("controller");
            string id =
                System.Web.HttpContext.Current.Request.RequestContext.RouteData.Values.ContainsKey("id") ?
                System.Web.HttpContext.Current.Request.RequestContext.RouteData.Values["id"].ToString() :
                string.Empty;

            yield return new TopMenuItemViewModel {
                Title = "Home",
                Url = "/",
                Active =  controller == "Home" && action == "Index" };
            yield return new TopMenuItemViewModel
            {
                Title = "Hot deals",
                Url = Url.Action("Deals", "Search"),
                Active = controller == "Search" && action == "Deals"
            };
            foreach(var cat in context.Categories)
            {

                yield return new TopMenuItemViewModel
                {
                    Title = cat.Name,
                    Url = Url.Action("View", "Category",new { id = cat.Id}),
                    Active = controller == "Category" && action == "View" && 
                    id == cat.Id.ToString()
                };
            }

        }

        protected IEnumerable<ViewModels.ProductBoxViewModel> ConvertProducts(IEnumerable<Models.Product> products)
        {
            foreach (var prod in products)
                yield return prod.ToProductBoxViewModel();

        }


        protected CategoryMenuViewModel CreateCategoryMenu(Models.Model1 context)
        {
            return new CategoryMenuViewModel
            {
                CategoryMenuItems = context.Categories.Select(r=>new CategoryMenuViewModel.CategoryMenuItemViewModel
                {
                    Id = r.Id,
                    Name = r.Name
                }).ToList()
            }; 
        }

    }
}