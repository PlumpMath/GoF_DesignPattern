namespace GoF.DesignPattern.Proxy
{
    internal class Customer
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public int AccountNo { get; private set; }
        public string Address { get; private set; }

        private readonly IBank _bankOperations;

        public Customer(IBank bankOperations, string name, string category, int accountNo, string address)
        {
            _bankOperations = bankOperations;
            Name = name;
            Category = category;
            AccountNo = accountNo;
            Address = address;
        }

        public void Withdraw(int amount)
        {
            _bankOperations.Withdraw(amount, Category);
        }

        public void ApplyForLoan(string type)
        {
            _bankOperations.ApplyForLoan("Study", Category);
        }

        public void Deposit(int amount)
        {
            _bankOperations.Deposit(amount);
        }

        public void GetBalance()
        {
            _bankOperations.GetBalance();
        }

        public void Transfer(int toAccount, int amount)
        {
            _bankOperations.Transfer(toAccount, amount);
        }

        public void CallHomeBankingOfficer()
        {
            _bankOperations.CallHomeBankingOfficer(Category);
        }
    }
}
