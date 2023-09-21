using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class Account : IAccount

    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }

        public decimal DepositMoney(decimal deposit)
        {
            Balance += deposit;
            return Balance;
        }

        public decimal WithdrawMoney(decimal withdrawal)
        {
            Balance -= withdrawal;
            return Balance;
        }

        public string Transaction(string transaction)
        {
             
         return "hello";
            
        }
    }
}
