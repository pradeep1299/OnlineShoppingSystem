using OnlineShoppingSystem_Entity;
using System.Collections.Generic;


namespace OnlineShoppingSystem_DAL
{
    public class CustomerRespository
    {
        public static List<CustomerEntity> customers = new List<CustomerEntity>();
        public void Add(CustomerEntity customer)
        {
            customers.Add(customer);
        }
    }
}
