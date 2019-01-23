using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StefanShopWeb.ViewModels
{
    public class TopMenuViewModel
    {
        public List<TopMenuItemViewModel> Items { get; set; }
    }
    public class TopMenuItemViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
    }
}