namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CustomerDetails", name: "userRole", newName: "Role");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.CustomerDetails", name: "Role", newName: "userRole");
        }
    }
}
