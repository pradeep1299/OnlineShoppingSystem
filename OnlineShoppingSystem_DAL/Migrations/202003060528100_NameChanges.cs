namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameChanges : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductDetails", newName: "Products");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Products", newName: "ProductDetails");
        }
    }
}
