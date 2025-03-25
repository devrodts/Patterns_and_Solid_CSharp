using System;

namespace ConsoleAppExampleOne.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }
        
        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw Amount cannot be negative");
            }
            if (amount > balance)
            {
                throw new ArgumentException("Insufficient funds");
            }
            balance -= amount;
        }
    }
}