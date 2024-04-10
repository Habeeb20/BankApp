using System;
using System.Reflection.Emit;
using OOP_Project.Services.Implementations;
using OOP_Project.Services.Interface;
using OOP_Project.Menu;
using OOP_Project.Dto.Command;
using OOP_Project.Entities;

namespace  OOP_Project.Menu.customerMenu
{
    public class CustomerRegistration
    {
        ICustomerService _customerService;
        public CustomerRegistration()
        {
            _customerService = new CustomerServices();
        }

        public void RegisterMenu()
        {
            Console.WriteLine("Enter your first name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lName = Console.ReadLine();
            Console.WriteLine("enter your phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("enter your password");
            string newpass = Console.ReadLine();
            Console.WriteLine("confirm your password");
            string confirmPassword = Console.ReadLine();
            string confirmPass;
            while (!confirmPassword.Equals(newpass))
            {
                Console.WriteLine("Confirm password");
                confirmPassword = Console.ReadLine();
            }
            //
            Console.WriteLine("Choose a gender\n1. Male\t2. Female");
            int gender = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your nin");
            string NIN = Console.ReadLine();

            var customerDto = new CreateCustomerRequest
            {
                FirstName = fName,
                LastName = lName,
                Phone = phone,
                NIN = NIN,
                Gender = (Gender) gender,
                Password = newpass
               
            };
            var isCustomerRegistered = _customerService.Register(customerDto);
            if(isCustomerRegistered != isCustomerRegistered)
            {
                System.Console.WriteLine("something went wrong");
            } else {
                System.Console.WriteLine("successfully logged in");
            }

        }

        public void Login()
        {
            Entities.Customer customer = null;
            while(customer is null)
            {
                Console.WriteLine("enter your phone num");
                string phone = Console.ReadLine();
                Console.WriteLine("create a password");
                string pass= Console.ReadLine();
          
            }
            if(customer is null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            System.Console.WriteLine("Login successful");
          

        }
    }
}