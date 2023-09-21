using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class Tests
    {
        //private Core _core;

        [Test] public void Test()
        {
            Bank bank = new Bank();

            bank.add(new Account { Name = "Annefleur Hay", Address = "Woonwijk", Balancec = 2000m });

            Assert.IsTrue(bank.Count() == 1);
        }

    }
}