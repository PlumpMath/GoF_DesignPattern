using System;

namespace GoF.DesignPattern.Facade
{
    internal class Payment
    {
        public void VerifyCreditCard(double creditNumber)
        {
            Console.WriteLine("Credit card verification successful for card number " + creditNumber);
        }

        public void PerformTransaction(double creditNumber, int amount)
        {
            Console.WriteLine("Processing transaction for " + amount + " from card number " + creditNumber);
        }
    }
}
