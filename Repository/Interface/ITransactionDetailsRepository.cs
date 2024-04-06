using System.Transactions;
using OOP_Project.Entities;
namespace OOP_Project.Repository.Interface
{
    public interface ITransactionDetailsRepository
    {
         bool Add(TransactionDetails transaction);

         List<TransactionDetails> GetAll(int pin);

         List<TransactionDetails> GetByDate(int pin, DateTime transactionDate);
    }
}