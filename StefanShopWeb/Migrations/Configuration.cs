namespace StefanShopWeb.Migrations
{
    using StefanShopWeb.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StefanShopWeb.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StefanShopWeb.Models.Model1 context)
        {
            //  This method will be called after migrating to the latest version.
            context.Categories.AddOrUpdate(r=>r.Id, 
                new Category {  Id=1, Name="Computers & Laptops" },
                 new Category { Id = 2, Name = "Camera & Photos" },
                 new Category { Id = 3, Name = "Smartphones & Tablets" },
                 new Category { Id = 4, Name = "Video Games & Consoles" },
                  new Category { Id = 5, Name = "Gadgets" }
                );

            context.Products.AddOrUpdate( r=>r.ProductKey,
                new Product {
                    ProductKey = "0000001212", Name = "Apple IPhone 6s", Price = 123,
                    Created = new DateTime(2018,1,1),
                    Category = context.Categories.FirstOrDefault(c => c.Id == 3) },
                new Product {
                    ProductKey = "80025566", Name = "Huawei Mediapad",
                    Created = new DateTime(2018, 1, 1),

                    Price = 12, Category = context.Categories.FirstOrDefault(c => c.Id == 3) },
                new Product {
                    ProductKey = "30057741",
                    Created = new DateTime(2018, 1, 1),

                    Name = "Sony Headphones", Price = 220, CampaignPrice=99, Category = context.Categories.FirstOrDefault(c => c.Id == 5) },
                    new Product
                    {
                        Created = DateTime.Now.AddDays(-1),
                        ProductKey = "AA666712",
                        Name = "Canon STM Kit",
                        Price = 300,
                        CampaignPrice = 225,
                        Category = context.Categories.FirstOrDefault(c => c.Id == 2)
                    }
                );

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
