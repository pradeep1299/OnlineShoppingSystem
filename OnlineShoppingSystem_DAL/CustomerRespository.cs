using OnlineShoppingSystem_Entity;
using System.Collections.Generic;
using System.Linq;


namespace OnlineShoppingSystem_DAL
{
    public class CustomerRespository
    {
        //public static List<CustomerDetails> customers = new List<CustomerDetails>();
        OnlineShoppingDB_Context context = new OnlineShoppingDB_Context();

        //static CustomerRespository()
        //{
        //    customers.Add(new CustomerDetails(5,"Siva",9003005001,"siva@gmail.com","Siva@123"));
        //}
        public IEnumerable<CustomerDetails> GetCustomer()
        {
            return context.CustomerDB.ToList();
        }
        public void Add(CustomerDetails customer)
        {
            context.CustomerDB.Add(customer);
            context.SaveChanges();
        }
    }
}
