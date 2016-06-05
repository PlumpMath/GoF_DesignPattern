namespace GoF.DesignPattern.Proxy
{
    internal interface IBank
    {
        void Withdraw(int amount, string type);
        void ApplyForLoan(string loanType, string type);
        void Deposit(int amount);
        void GetBalance();
        void Transfer(int toAccount, int amount);
        void CallHomeBankingOfficer(string type);
    }
}
