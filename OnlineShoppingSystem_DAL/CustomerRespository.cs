using OnlineShoppingSystem_Entity;
using System.Collections.Generic;
using System.Linq;


namespace OnlineShoppingSystem_DAL
{
    public class CustomerRespository
    {
        public static List<CustomerDetails> customers = new List<CustomerDetails>();
        OnlineShoppingDB_Context context = new OnlineShoppingDB_Context();

        public IEnumerable<CustomerDetails> GetCustomer()
        {
            // return new List<CustomerDetails>();
            return context.CustomerDB.ToList();
        }
        public void Add(CustomerDetails customer)
        {
            context.CustomerDB.Add(customer);
            context.SaveChanges();
        }
    }
}
