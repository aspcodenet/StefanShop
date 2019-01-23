using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.Infrastructure
{
    public static class Converters
    {
        public static ViewModels.ProductBoxViewModel ToProductBoxViewModel(this Models.Product prod)
        {
            return new ViewModels.ProductBoxViewModel
            {
                ProductId = prod.ProductKey,
                ProductName = prod.Name,
                ProductPrice = prod.CampaignPrice == 0 ? prod.Price : prod.CampaignPrice,
                OriginalPrice = prod.Price,
                DiscountPercent = prod.CampaignPrice == 0 ? 0 : Convert.ToInt32((prod.Price - prod.CampaignPrice)*100 / prod.Price),
                IsNew = prod.Created > DateTime.Now.AddMonths(-1),
                MainImageUrl = GetImagesFor(prod.ProductKey).First()
            };
        }
        public static IEnumerable<string> GetImagesFor(string productId)
        {
            var path = HttpContext.Current.Request.MapPath("~/img/products/");
            return System.IO.Directory.GetFiles(path, "*_" + productId + ".*").
                Select(r => "/img/products/" + System.IO.Path.GetFileName(r));

        }
    }
}