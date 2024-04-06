using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Project.Entities
{
    public class User : BaseEntity
    {
        public required string FirstName;
        public required string LastName;
        public required string PhoneNumber;
        public required string Password;
        public required Gender Gender;

        public User(string firstName, string lastName, string phoneNumber,string password, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Password = password;
            Gender = gender;

            
        }
    }
}