using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public interface IAccount
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Balance {  get; set; }
        public int Id { get; set; }

        public string Type {  get; set; }

        decimal DepositMoney(decimal deposit);
        decimal WithdrawMoney(decimal withdrawal);

        string Transaction(int transaction);

    }
}
