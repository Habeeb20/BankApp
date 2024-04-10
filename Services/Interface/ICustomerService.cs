using OOP_Project.Dto.Command;
using OOP_Project.Entities;
namespace OOP_Project.Services.Interface
{
    public interface ICustomerService
    {
         bool Register(CreateCustomerRequest request);
         Customer GetCustomer(string phone, string password);
         
    };
}

