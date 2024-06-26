using System.Linq.Expressions;
using OOP_Project.Entities;
using OOP_Project.Dto.Command;
using OOP_Project.Repository.Implementation;
using OOP_Project.Repository.Interface;
using OOP_Project.Services.Interface;
namespace OOP_Project.Services.Implementations
{
    public class CustomerServices : ICustomerService
    {
        private static  ICustomerRepository _customerRepository;

        public CustomerServices()
        {
            _customerRepository = new CustomerRepository();
        }
        //dto
        public bool Register(CreateCustomerRequest request)
        {
            if(request is null)
            {
                return false;
            }
            Customer customer = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone,
                Password = request.Password,
                Gender = request.Gender,
                NIN = request.NIN
            };
            var isCustomerAdded = _customerRepository.Add(customer);
            return isCustomerAdded;
            
        }

        public Customer GetCustomer(string phone, string password)
        {
            var customer = _customerRepository.Get(phone, password);
            return customer;
        }

      
    };
}