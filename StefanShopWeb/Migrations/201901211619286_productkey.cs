namespace StefanShopWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "ProductKey", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "ProductKey");
            DropColumn("dbo.Products", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "ProductKey");
            AddPrimaryKey("dbo.Products", "Id");
        }
    }
}
