using System.Data.Entity;
using OnlineShoppingSystem_Entity;

namespace OnlineShoppingSystem_DAL
{
    public class OnlineShoppingDB_Context : DbContext
    {
        public OnlineShoppingDB_Context() : base("Connection")
        {

        }
        public DbSet<CustomerDetails> CustomerDB
        {
            get;
            set;
        } 
    }
}
