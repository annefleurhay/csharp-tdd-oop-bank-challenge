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

            //Bank bank = new Bank();

            Account account = new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Current", Id = 16 };
            Account account2 = new Account { Name = "Chiara", Address = "Serving", Balance = 13400, Type = "Current", Id = 5 };

            
            account.DepositMoney(200);
            account2.DepositMoney(500);

            Assert.IsTrue(account.Balance == 2200);
            Assert.IsTrue(account2.Balance == 13900);


        }

        [Test] public void WithdrawMoney() {

            Account account = new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Current", Id = 16 };

            account.WithdrawMoney(100);

            Assert.IsTrue(account.Balance == 1900);
        }

    }
}