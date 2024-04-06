using OOP_Project.Entities;
namespace OOP_Project.Repository.Interface
{
    public interface IAccountRepository
    {
        bool Add(Account account);

        Account GetByPin( int pin);

        bool Update(Guid id, Account account);

        bool Delete(Account account);


    } 

}

