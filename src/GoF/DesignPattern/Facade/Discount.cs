using System;

namespace GoF.DesignPattern.Facade
{
    internal class Discount
    {
        public void ApplyDiscount(int price, int discount)
        {
            Console.WriteLine("Discount of " + discount + " applied on price " + price);
        }
    }
}
