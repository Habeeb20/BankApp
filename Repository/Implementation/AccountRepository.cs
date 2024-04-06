using System.Data.Common;
using OOP_Project.Entities;
using OOP_Project.Repository.Interface;

namespace OOP_Project.Repository.Implementation
{
    public class AccountRepository : IAccountRepository
    {
        private readonly List<Account> Accounts_DB = new List<Account>();

        public bool Add(Account account)
        {
            if(account is not null)
            {
                Accounts_DB.Add(account);
                return true;
            }
            return false;

        }

        public Account GetByPin( int pin)
        {
            var acct = Accounts_DB.Find(x => x.Pin == pin );
            if(acct is not null)
            {
                return acct;

            }
            return null;

        }

        public bool Update(Guid id, Account account)
        {
            var acct = from x in Accounts_DB where x.Id == id select x;
            if(acct is not null)
            {
                Accounts_DB.Remove((Account)acct);
            }
            return true;


        } 

        public bool Delete(Account account)
        {
            if(account is not null )
            {
                Accounts_DB.Remove(account);
                return true;

            }
            return false;

        }
        
    }
}
