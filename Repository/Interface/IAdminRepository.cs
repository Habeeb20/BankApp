using OOP_Project.Entities;

namespace OOP_Project.Repository.Interface
{
    public interface IAdminRepository
    {
        bool Add(Admin admin);

        bool Delete(Admin admin);
         
    }
}