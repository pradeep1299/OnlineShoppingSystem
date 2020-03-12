namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoryId)
                .Index(t => t.CategoryId, unique: true)
                .Index(t => t.CategoryName, unique: true);
            
            CreateIndex("dbo.Products", "Category ID");
            AddForeignKey("dbo.Products", "Category ID", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category ID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category ID" });
            DropIndex("dbo.Categories", new[] { "CategoryName" });
            DropIndex("dbo.Categories", new[] { "CategoryId" });
            DropTable("dbo.Categories");
        }
    }
}
