﻿using OnlineShoppingSystem_DAL;
using OnlineShoppingSystem_Entity;

namespace OnlineShoppingSystem_BL
{
    public class ValidateLogin
    {
        public static CustomerDetails validateSignIn(CustomerDetails customer)
        {
            return CustomerRespository.LoginValidate(customer);
        }
    }
}
