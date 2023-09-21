using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public interface ITransaction
    {
        //niet gebruiken

        DateTime Date { get; set; }
        decimal Credit { get; set; }
        decimal Debit { get; set; }
        decimal Balance { get; set; }
         string TransactionType { get; set; }


    }
}
