namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sp : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Category_Insert",
                p => new
                    {
                        CategoryName = p.String(maxLength: 100),
                    },
                body:
                    @"INSERT [dbo].[Categories]([CategoryName])
                      VALUES (@CategoryName)
                      
                      DECLARE @CategoryId int
                      SELECT @CategoryId = [CategoryId]
                      FROM [dbo].[Categories]
                      WHERE @@ROWCOUNT > 0 AND [CategoryId] = scope_identity()
                      
                      SELECT t0.[CategoryId]
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[CategoryId] = @CategoryId"
            );
            
            CreateStoredProcedure(
                "dbo.Category_Update",
                p => new
                    {
                        CategoryId = p.Int(),
                        CategoryName = p.String(maxLength: 100),
                    },
                body:
                    @"UPDATE [dbo].[Categories]
                      SET [CategoryName] = @CategoryName
                      WHERE ([CategoryId] = @CategoryId)"
            );
            
            CreateStoredProcedure(
                "dbo.Category_Delete",
                p => new
                    {
                        CategoryId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Categories]
                      WHERE ([CategoryId] = @CategoryId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Category_Delete");
            DropStoredProcedure("dbo.Category_Update");
            DropStoredProcedure("dbo.Category_Insert");
        }
    }
}
