using System;

namespace GoF.DesignPattern.State
{
    internal class PurchaseInProcess : IFlashSaleStates
    {
        private readonly Ecommerce _ecommerce;

        public PurchaseInProcess(Ecommerce ecommerce)
        {
            _ecommerce = ecommerce;
        }

        public void PaymentDone()
        {
            Console.WriteLine("You have already payed. Please wait before another purchase.");
        }

        public void RefundPayment()
        {
            Console.WriteLine("Refunding your payment");
            _ecommerce.SetState(new SaleActive(_ecommerce));
        }

        public void PressConfirm()
        {
            Console.WriteLine("You choose to confirm. Processing your request.");
            _ecommerce.SetState(new ProductSold(_ecommerce));
        }

        public void Ship()
        {
            Console.WriteLine("Inappropriate action at this state.");
        }
    }
}
