using System;

namespace GoF.DesignPattern.Facade
{
    internal class Shipping
    {
        public void InitiateShipping(string mode, int productId)
        {
            Console.WriteLine("Product Shipped by " + mode);
        }
    }
}
