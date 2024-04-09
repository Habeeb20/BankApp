using OOP_Project.Entities;
namespace OOP_Project.Repository.Interface
{
    public interface ICustomerRepository
    {
        bool Add(Customer customer);

        Customer GetByNIN(string nin);

        Customer Get(string phone, string password);

        Customer Update(Guid id, Customer customer);

        bool Delete(Customer customer);

         
    }
}