namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "userRole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerDetails", "userRole");
        }
    }
}
