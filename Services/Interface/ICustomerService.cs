using OOP_Project.Dto.Command;
namespace OOP_Project.Services.Interface
{
    public interface ICustomerService
    {
         bool Register(CreateCustomerRequest request);
         
    };
}

