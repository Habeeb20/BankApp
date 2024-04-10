using System;
using OOP_Project.Entities;
using OOP_Project.Services.Implementations;
using OOP_Project.Services.Interface;
namespace OOP_Project.Menu.customerMenu
{
    public class CustomerLogin
    {
        CustomerLogin _customerLogin;
        ICustomerService customerService;
        Customer customer;

        public CustomerLogin()
        {
            customerService = new CustomerServices();

        }

        public void Login()
        {
            while(customer is null)
        {
            System.Console.WriteLine("#########LOGIN########");
            System.Console.WriteLine("please input your phone number");
            string phone = Console.ReadLine();
            System.Console.WriteLine("please input your password");
            string pass = Console.ReadLine();
            customer = customerService.GetCustomer(phone, pass);
            if(customer is null)
            {
                System.Console.WriteLine("invalid details");
            }
        };
        Console.WriteLine("login is successful");

        }
        

    }
}