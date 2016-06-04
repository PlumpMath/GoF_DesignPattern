using System;

namespace GoF.DesignPattern.Facade
{
    internal class Address
    {
        public void AddAddress(string customer)
        {
            Console.WriteLine("Address details added for customer : " + customer);
        }

        public void GetAddress(string customer)
        {
            Console.WriteLine("Address for customer " + customer + " : BHagwati Ashiyana");
        }

        public void UpdateAddress(string customer)
        {
            Console.WriteLine("Address updated successfully");

        }
    }
}
