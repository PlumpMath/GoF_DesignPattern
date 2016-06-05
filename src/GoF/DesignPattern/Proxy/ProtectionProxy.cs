using System;

namespace GoF.DesignPattern.Proxy
{
    internal class ProtectionProxy : IBank
    {
        private readonly Bank _bank;
        private int _balance;

        public ProtectionProxy(Bank bank)
        {
            _bank = bank;
        }

        public void Withdraw(int amount, string type)
        {
            if (amount > 500)
            {
                if (type == "Gold")
                {
                    _bank.Withdraw(amount, type);
                }
                else
                {
                    Console.WriteLine("Only Gold customer can withdraw amount greater than 500");
                }
            }
            else
            {
                _bank.Withdraw(amount, type);
            }
        }

        public void ApplyForLoan(string loanType, string type)
        {
            if (loanType == "Study")
            {
                if (type == "Gold")
                {
                    _bank.ApplyForLoan(loanType, type);
                }
                else
                {
                    Console.WriteLine("Only Gold customer can apply for study loan");
                }
            }
            else
            {
                _bank.ApplyForLoan(loanType, type);
            }
            Console.WriteLine("Application for " + type + " loan is successful");
        }

        public void Deposit(int amount)
        {
            _bank.Deposit(amount);
        }

        public void GetBalance()
        {
            _bank.GetBalance();
        }

        public void Transfer(int toAccount, int amount)
        {
            _bank.Transfer(toAccount, amount);
        }

        public void CallHomeBankingOfficer(string type)
        {
            if (type == "Gold")
            {
                _bank.CallHomeBankingOfficer(type);
            }
            else
            {
                Console.WriteLine("Only Gold customer can have Home banking facility");
            }
        }
    }
}

