using System;

namespace GoF.DesignPattern.State
{
    internal class OutOfStock : IFlashSaleStates
    {
        public void PaymentDone()
        {
            Console.WriteLine("You can't pay becuause the Product is out of stock.");
        }

        public void RefundPayment()
        {
            Console.WriteLine("No payment accepted as the Product was already out of stock.");
        }

        public void PressConfirm()
        {
            Console.WriteLine("We cannot process the item as Product is already out of stock.");
        }

        public void Ship()
        {
            Console.WriteLine("No product shipped");
        }
    }
}
