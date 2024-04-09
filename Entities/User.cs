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
        public required string Phone;
        public required string Password;
        public required Gender Gender;

       
    }
}