namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Unique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerDetails", "E-mail Address", c => c.String(maxLength: 50));
            CreateIndex("dbo.CustomerDetails", "Mobile", unique: true);
            CreateIndex("dbo.CustomerDetails", "E-mail Address", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.CustomerDetails", new[] { "E-mail Address" });
            DropIndex("dbo.CustomerDetails", new[] { "Mobile" });
            AlterColumn("dbo.CustomerDetails", "E-mail Address", c => c.String());
        }
    }
}
