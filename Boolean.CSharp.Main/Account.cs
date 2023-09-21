using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class Account : Transaction, IAccount

    {
        private List<Transaction> _transactions = new List<Transaction>();


        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }

        public decimal DepositMoney(decimal deposit)
        {
            Balance += deposit;
            _transactions.Add(new Transaction { Date = DateTime.Now, Credit = deposit, Balance = Balance, TransactionType= "Credit" });
            return Balance;
        }

        public decimal WithdrawMoney(decimal withdrawal)
        {
            Balance -= withdrawal;
            _transactions.Add(new Transaction { Date = DateTime.Now, Debit = withdrawal, Balance = Balance, TransactionType = "Debit" });
            return Balance;
        }

        public string StatementHistory()
        {
           
            StringBuilder statement = new StringBuilder();
            Console.WriteLine("{0,10} || {1,10} || {2,10} || {3,10} ", "Date", "Credit", "Debit", "Balance");

            decimal runningBalance = 0;

            foreach (var transaction in _transactions.OrderBy(t => t.Date)) 
            {
              
                string transactionType = transaction.TransactionType;

                
                decimal creditAmount = transactionType == "Credit" ? transaction.Credit : 0;
                decimal debitAmount = transactionType == "Debit" ? transaction.Debit : 0;

                
                runningBalance += creditAmount - debitAmount;

                
                Console.WriteLine("{0,10} || {1,10} || {2,10} || {3,10} ",
                    transaction.Date.ToShortDateString(),
                    creditAmount.ToString("0.00"),
                    debitAmount.ToString("0.00"),
                    runningBalance.ToString("0.00"));
            }

            return statement.ToString();


        }

        public string Transaction(int transactionAmount)
        {
             
         return "hello";
            
        }
    }
}
