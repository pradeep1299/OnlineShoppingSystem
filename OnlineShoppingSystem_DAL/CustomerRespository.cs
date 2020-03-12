using OnlineShoppingSystem_Entity;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Data.Entity;

namespace OnlineShoppingSystem_DAL
{
    public class CustomerRespository
    {
        public static string userRole;
        //public static List<CustomerDetails> customers = new List<CustomerDetails>();

        public IEnumerable<CustomerDetails> GetCustomer()
        {
            using(OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                return context.Customers.ToList();
            }
            // return new List<CustomerDetails>();
        }
        public void Add(CustomerDetails customer)
        {
            using(OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                context.Entry(customer).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public static CustomerDetails LoginValidate(CustomerDetails customer)
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                customer = context.Customers.Where(id => (customer.CustomerEMail == id.CustomerEMail || customer.CustomerMobile == id.CustomerMobile && customer.CustomerPassword == id.CustomerPassword)).SingleOrDefault();
                try
                {
                    return customer;
                }
                catch (NullReferenceException)
                {
                    return null;
                }
            }
        }
    }
}
