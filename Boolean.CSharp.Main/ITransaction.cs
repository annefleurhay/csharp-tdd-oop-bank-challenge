using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public interface ITransaction
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public decimal CurrentBalance { get; set; }


    }
}
