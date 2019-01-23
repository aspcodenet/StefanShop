using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.ViewModels
{



    public class DealsPageViewModel 
    {
        public CategoryMenuViewModel CategoryMenuViewModel { get; set; }
        public List<ProductBoxViewModel> Products { get; set; }
    }
}