using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Collections.Generic;
using System;

namespace OnlineShoppingSystem_BL
{
    interface ICustomerBL
    {
        void AddCustomer(CustomerDetails customer);
        IEnumerable<CustomerDetails> GetCustomer();
    }
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
        public CustomerDetails GetCustomerDetails(int id)
        {
            return customerRespository.GetCustomerDetails(id);
        }
        public void CustomerUpdate(CustomerDetails Customer)
        {
            CustomerRespository.CustomerUpdate(Customer);
        }
    }
}
