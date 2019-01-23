using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StefanShopWeb.Models
{
    public class Product
    {
        [Key]
        public string ProductKey { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal CampaignPrice { get; set; }
        public virtual Category Category { get; set; }
        public DateTime Created { get; set; }
    }
    public class Category
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

}