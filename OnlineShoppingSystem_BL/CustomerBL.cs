using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Collections.Generic;

namespace OnlineShoppingSystem_BL
{
    public class CustomerBL
    {
        CustomerRespository customerRespository = new CustomerRespository();
        public void AddCustomer(CustomerDetails customer)
        {
            customerRespository.Add(customer);
        }
        public IEnumerable<CustomerDetails> GetCustomer()
        {
            return customerRespository.GetCustomer();
        }
    }
}
