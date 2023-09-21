using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Bank
    {
        //Lijst met accounts
        private List<IAccount> _bankAccounts = new List<IAccount>();

        private List<ITransaction> _transactionhistory = new List<ITransaction>();
        

        



       

        public void AddCurrentAccount(IAccount account)
        {
            _bankAccounts.Add(account);
        }

        public void AddSavingsAccount(IAccount account)
        {
            _bankAccounts.Add(account);
        }

        public int Count()
        {
            return _bankAccounts.Count;
        }

       

        public List<IAccount> bankAccounts { get { return _bankAccounts; } }
        public List<ITransaction> transactionhistory { get {  return _transactionhistory; } }
    }
}
