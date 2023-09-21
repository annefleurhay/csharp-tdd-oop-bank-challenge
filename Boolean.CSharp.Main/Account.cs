using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }



        public decimal DepositMoney(decimal deposit) //parameter welke ID je nodig hebt?
        {
            Balance += deposit;
            return Balance;
        }

        public void WithdrawMoney(int v)
        {
           
        }

        //public decimal DepositMoney(decimal deposit)
        //{
        //    return 50;
        //} wellicht toch een optie om deposits en withdrawels te doen in de accounts?
    }
}
