namespace OOP_Project.Entities
{
    public class TransactionDetails :BaseEntity
    {
        public int Pin;
        public decimal Amount;

        public DateTime TransactionDate = DateTime.Now;

        public string? Description;

        public TransactionType TransactionType;

        public string? ReceiverName;

        public string? ReceiverAcctNum;

        public string? ReceiverBank;

      
    }
}