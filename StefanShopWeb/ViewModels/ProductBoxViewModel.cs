using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.ViewModels
{
    public class ProductBoxViewModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool IsNew { get; set; }
        public string MainImageUrl { get; set; }
    }
}