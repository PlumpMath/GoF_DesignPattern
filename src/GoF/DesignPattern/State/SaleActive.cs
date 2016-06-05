using System;

namespace GoF.DesignPattern.State
{
    internal class SaleActive : IFlashSaleStates
    {
        private readonly Ecommerce _ecommerce;

        public SaleActive(Ecommerce ecommerce)
        {
            _ecommerce = ecommerce;
        }

        public void PaymentDone()
        {
            Console.WriteLine("You made a payment. Payment was accepted");
            _ecommerce.SetState(new PurchaseInProcess(_ecommerce));
        }

        public void RefundPayment()
        {
            Console.WriteLine("You havent made a payment yet.");
        }

        public void PressConfirm()
        {
            Console.WriteLine("You pressed Confirm button but you havent done payment yet.");
        }

        public void Ship()
        {
            Console.WriteLine("You need to first make payment.");
        }
    }
}
