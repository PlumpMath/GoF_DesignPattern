using System;

namespace GoF.DesignPattern.Proxy
{
    internal class Bank : IBank
    {
        private int _balance;
        public void Withdraw(int amount, string type)
        {
            Console.WriteLine("Amount " + amount + " withdrawn from account.");
            _balance -= amount;
        }

        public void ApplyForLoan(string loanType, string type)
        {
            Console.WriteLine("Application for " + type + " loan is successful");
        }

        public void Deposit(int amount)
        {
            Console.WriteLine("Amount " + amount + " desposited in account");
            _balance += amount;
        }

        public void GetBalance()
        {
            Console.WriteLine("Current Balance : " + _balance);
        }

        public void Transfer(int toAccount, int amount)
        {
            Console.WriteLine("Amount " + amount + " transfered to bank account " + toAccount);
        }

        public void CallHomeBankingOfficer(string type)
        {
            Console.WriteLine("Our home baking officer will reach to you imediately.");
        }
    }
}
