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
            Current account = new Current { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type="Current", Id= 16 };
            IAccount account1 = new Current { Name = "haha", Address = "noorwegen", Balance = 300m };
            
            //bank.Add(new Account { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m });
     
            bank.AddCurrentAccount(account1);
            Assert.IsTrue(bank.Count() == 1);
        }

        [Test] public void AddSavings()
        {
            Bank bank = new Bank();
            Current account = new Current { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Savings", Id = 16 };

            bank.AddSavingsAccount(account);

            Assert.IsTrue(bank.Count() == 1);


        }

        [Test] public void DepositMoney() 
        {

            

            Current account = new Current { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Current", Id = 16 };
            Current account2 = new Current { Name = "Chiara", Address = "Serving", Balance = 13400, Type = "Current", Id = 5 };

            
            account.DepositMoney(200);
            account2.DepositMoney(500);

            Assert.IsTrue(account.Balance == 2200);
            Assert.IsTrue(account2.Balance == 13900);


        }

        [Test] public void WithdrawMoney() {

            Current account = new Current { Name = "Annefleur", Address = "Woonwijk", Balance = 2000m, Type = "Current", Id = 16 };

            account.WithdrawMoney(100);

            Assert.IsTrue(account.Balance == 1900);
        }

        [Test] public void OnetransactionStatement() 
        { 
            Current account = new () { Name = "Annefleur", Address = "Woonwijk", Balance = 0, Type = "Current", Id = 16 };
            account.DepositMoney(200);

            Assert.IsTrue(account.Transaction("haha") == "haha");
            

        }

    }
}