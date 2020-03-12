using System.Data.Entity;
using OnlineShoppingSystem_Entity;

namespace OnlineShoppingSystem_DAL
{
    public class OnlineShoppingDB_Context : DbContext
    {
        public OnlineShoppingDB_Context() : base("Connection")
        {

        }
        public DbSet<CustomerDetails> Customers
        {
            get;
            set;
        }
        public DbSet<Product> Products
        {
            get;
            set;
        }
        public DbSet<Category> Categorys
        {
            get;
            set;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
