namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colomnName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CustomerDetails", name: "customerId", newName: "ID");
            RenameColumn(table: "dbo.CustomerDetails", name: "customerName", newName: "Name");
            RenameColumn(table: "dbo.CustomerDetails", name: "customerMobile", newName: "Mobile");
            RenameColumn(table: "dbo.CustomerDetails", name: "customerPassword", newName: "Password");
            RenameColumn(table: "dbo.CustomerDetails", name: "customerEMail", newName: "E-mail Address");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.CustomerDetails", name: "E-mail Address", newName: "customerEMail");
            RenameColumn(table: "dbo.CustomerDetails", name: "Password", newName: "customerPassword");
            RenameColumn(table: "dbo.CustomerDetails", name: "Mobile", newName: "customerMobile");
            RenameColumn(table: "dbo.CustomerDetails", name: "Name", newName: "customerName");
            RenameColumn(table: "dbo.CustomerDetails", name: "ID", newName: "customerId");
        }
    }
}
