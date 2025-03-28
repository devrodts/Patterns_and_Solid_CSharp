using ConsoleAppExampleOne.src.OopPrinciples.Encapsulation;


// Bad Encapsulation
BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 100;
Console.WriteLine($"Account balance: {badAccount.balance}");


// Good Encapsulation
BankAccount account = new BankAccount(100);
Console.WriteLine($"Account balance: {account.GetBalance()}");
account.Deposit(50);
Console.WriteLine($"Account balance: {account.GetBalance()}");

