using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Account : IAcount
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Balancec { get; set; }
    }
}
