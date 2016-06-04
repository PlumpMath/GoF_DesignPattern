using System;

namespace GoF.DesignPattern.Facade
{
    internal class Inventory
    {
        public void AddProduct(int id, int quantity)
        {
            Console.WriteLine("Product added in inventory");
        }

        public bool IsProductAvailable(int id)
        {
            return true;
        }

        public void GetProduct(int id, int quantilty)
        {
            Console.WriteLine("Product with ID " + id + " fetched from inventory");
        }
    }
}
