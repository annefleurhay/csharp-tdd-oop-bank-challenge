using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class Tests
    {
        //private Core _core;

        [Test] public void AddCurrent()
        {
            Bank bank = new Bank();
            Account account = new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type="Current", Id= 16 };
            IAccount account1 = new Account { Name = "haha", Address = "noorwegen", Balance = 300m };
            
            //bank.Add(new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m });
     
            bank.AddCurrentAccount(account1);
            Assert.IsTrue(bank.Count() == 1);
        }

        [Test] public void AddSavings()
        {
            Bank bank = new Bank();
            Account account = new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Savings", Id = 16 };

            bank.AddSavingsAccount(account);

            Assert.IsTrue(bank.Count() == 1);


        }

        [Test] public void DepositMoney() 
        {

            Bank bank = new Bank();

            Account account = new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Savings", Id = 16 };

            account.DepositMoney(200);

            Assert.IsTrue(account.Balance == 2200);


        }

    }
}