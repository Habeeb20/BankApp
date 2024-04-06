using System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OOP_Project.Entities
{
      public class Admin : User
    {
        public Admin(string firstName, string lastName, string phoneNumber, string password, Gender gender)
        :base(firstName,lastName,phoneNumber,password,gender)
        {
            
        }
    }
}