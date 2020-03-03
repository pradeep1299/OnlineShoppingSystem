﻿namespace OnlineShoppingSystem_DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineShoppingSystem_DAL.OnlineShoppingDB_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OnlineShoppingSystem_DAL.OnlineShoppingDB_Context";
        }

        protected override void Seed(OnlineShoppingSystem_DAL.OnlineShoppingDB_Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
