using OnlineShoppingSystem_Entity;
using System.Collections.Generic;
using System;
using System.Linq;


namespace OnlineShoppingSystem_DAL
{
    public class CustomerRespository
    {
        public static string userRole;
        //public static List<CustomerDetails> customers = new List<CustomerDetails>();
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
        public static string LoginValidate(CustomerDetails customer)
        {
            OnlineShoppingDB_Context context = new OnlineShoppingDB_Context();
            //bool isvalue = false;
            IEnumerable<CustomerDetails> user = context.CustomerDB.ToList();
            foreach(var value in user)
            {
                if((customer.customerEMail == value.customerEMail|| customer.customerMobile == value.customerMobile) && customer.customerPassword == value.customerPassword)
                {
                    //isvalue = true;
                    userRole = value.role;
                    break;
                }
            }
            return userRole;
        }
    }
}
