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
            _transactions.Add(new Transaction { Date = DateTime.Now, Credit = deposit, Balance = Balance });
            return Balance;
        }

        public decimal WithdrawMoney(decimal withdrawal)
        {
            Balance -= withdrawal;
            _transactions.Add(new Transaction { Date = DateTime.Now, Debit = withdrawal, Balance = Balance });
            return Balance;
        }

        public string StatementHistory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date       || credit  || debit  || balance");

            var sortedTransactonHistory = _transactions.OrderByDescending(t => t.Date);

            foreach (var transaction in sortedTransactonHistory)
            {
                sb.AppendLine($"{transaction.Date.ToString("dd/MM/yyyy")} || {transaction.Credit.ToString("0.00")} || {transaction.Debit.ToString("0.00")} || {transaction.Balance.ToString("0.00")}");

            }
            return sb.ToString();
        }

        public string Transaction(int transactionAmount)
        {
             
         return "hello";
            
        }
    }
}
