using OOP_Project.Entities; 
namespace OOP_Project.Dto.Command
{
    public class CreateCustomerRequest
    {
        public required string FirstName;
        public required string LastName;
        public required string Phone;
        public required string Password;
        public required Gender Gender;

        public required string Address;

        public required string NIN;

        
    }
}