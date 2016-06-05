using GoF.DesignPattern.Proxy;

namespace GoF.DesignPattern
{
    internal class ProxyMain
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer(new ProtectionProxy(new Bank()), "Chirag", "Silver", 1457894578, "Bhagwati Ashiyana");
            Customer customer2 = new Customer(new ProtectionProxy(new Bank()), "Abhishek", "Gold", 25481512, "Tulsi Baug");
            customer1.Deposit(1000);
            customer2.Deposit(1000);

            customer1.CallHomeBankingOfficer();
            customer2.CallHomeBankingOfficer();

            customer1.Withdraw(600);
            customer2.Withdraw(600);

            customer1.GetBalance();
            customer2.GetBalance();
        }
    }
}
