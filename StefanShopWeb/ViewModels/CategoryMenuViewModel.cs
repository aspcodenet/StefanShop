using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.ViewModels
{
    public class CategoryMenuViewModel
    {
        public CategoryMenuViewModel()
        {
            CategoryMenuItems = new List<CategoryMenuItemViewModel>();
        }
        public class CategoryMenuItemViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public List<CategoryMenuItemViewModel> CategoryMenuItems { get; set; }
    }
}