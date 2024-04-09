namespace OOP_Project.Entities
{
    public class Account: BaseEntity
    {

        public Guid CustomerId = default;

        public required int Pin;

        public required decimal Balance;

        public required decimal AcctNumber;

        public required BankName BankName;

        public Account(int pin, decimal acctNumber, decimal balance, BankName BankName)
        {
            Pin = pin;
            AcctNumber = acctNumber;
            Balance = Balance;
            BankName = BankName;

        }

        
    }
}