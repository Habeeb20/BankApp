using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP_Project.Entities;
using OOP_Project.Repository.Interface;

namespace OOP_Project.Repository.Implementation
{
    public class CustomerRepository: ICustomerRepository
    {
        List<Customer> Customers_DB = new List<Customer>();

        public bool Add(Customer customer)
        {
            if(customer is not null)
            {
                Customers_DB.Add(customer);
                return true;
            }
            return false;
        }

        public Customer GetByNIN(string nin)
        {
            var customer = Customers_DB.Find(c => c.NIN == nin);
            return customer;
        }

        public Customer GetById(Guid id)
        {
            var customer = Customers_DB.Find(c => c.Id == id);
            return customer;
        }

        public Customer? Update(Guid id, Customer customer)
        {
            var customerToUpdate = Customers_DB.Find(c => c.Id == id);
            if(customerToUpdate is not null)
            {
            Customers_DB.Remove(customerToUpdate);
                Customers_DB.Add(customer);
                return customer;
            }
            return null;
        }

        public bool Delete(Customer customer)
        {
            if(customer is not null)
            {
                Customers_DB.Remove(customer);
                return true;
            }
            return false;
        }
    }
}