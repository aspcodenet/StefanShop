using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.ViewModels
{
    public class CategoryPageViewModel
    {
        public CategoryMenuViewModel CategoryMenuViewModel { get; set; }
        public int CurrentCategoryId { get; set; }
        public string CurrentCategoryName { get; set; }
        public List<ProductBoxViewModel> Products { get; set; }
    }
}