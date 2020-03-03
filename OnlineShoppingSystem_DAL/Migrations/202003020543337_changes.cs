namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductID = c.Int(name: "Product ID", nullable: false, identity: true),
                        Name = c.String(),
                        AvaliableStock = c.Int(name: "Avaliable Stock", nullable: false),
                        CategoryID = c.Int(name: "Category ID", nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductDetails");
        }
    }
}
