using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Project.Entities
{
    public class Customer : User 
    {

        public string? Address;

        public required string NIN;
        public Customer():base()
        {
        }


        
    }
}