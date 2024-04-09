using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP_Project.Entities;
using OOP_Project.Repository.Interface;
namespace OOP_Project.Repository.Implementation
{
    public class TransactionDetailsRepository : ITransactionDetailsRepository
    {
        private readonly List<TransactionDetails> Transaction_DB = new List<TransactionDetails>();



          public bool Add(TransactionDetails transaction)
            {
                if(transaction is not null)
                {
                Transaction_DB.Add(transaction);
                    return true;
                }
            return false;

            }

            public List<TransactionDetails> GetAll(Guid accountId)
            {
            // List<TransactionDetails> transactions = Transaction_DB.Where(x => x.Pin == pin).ToList();

            List<TransactionDetails> transactions = new List<TransactionDetails>();

            foreach(var transaction in transactions)
            {
                if(transaction.AccountId == accountId)
                {
                    transactions.Add(transaction);
                }
            }
            return transactions;
            
            }

            public List<TransactionDetails> GetByDate(Guid accountId, DateTime transactionDate)
            {
            var transactions = Transaction_DB.FindAll(t => t.AccountId == accountId && t.TransactionDate.Date >= transactionDate);
            return transactions;
            }

        
    }
}