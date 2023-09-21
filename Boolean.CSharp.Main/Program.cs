// See https://aka.ms/new-console-template for more information
using Boolean.CSharp.Main;

//Console.WriteLine("Hello, World!");

Current account = new() { Name = "Annefleur", Address = "Woonwijk", Balance = 0, Type = "Current", Id = 16 };
account.DepositMoney(1000);
account.WithdrawMoney(200);

Console.WriteLine(account.StatementHistory());