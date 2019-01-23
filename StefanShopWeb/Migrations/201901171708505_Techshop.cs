namespace StefanShopWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Techshop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CampaignPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Created");
            DropColumn("dbo.Products", "CampaignPrice");
        }
    }
}
