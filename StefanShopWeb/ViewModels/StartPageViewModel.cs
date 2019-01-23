using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.ViewModels
{
    public class StartPageViewModel
    {
        public CategoryMenuViewModel CategoryMenuViewModel { get; set; }
        public class FirstPageProductViewModel
        {
            public string HeaderText { get; set; }
            public string PriceBefore { get; set; }
            public string PriceNow { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
        }
        public FirstPageProductViewModel FirstPageProduct { get; set; }
    }
}