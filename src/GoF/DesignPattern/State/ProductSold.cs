using System;

namespace GoF.DesignPattern.State
{
    internal class ProductSold : IFlashSaleStates
    {
        private readonly Ecommerce _ecommerce;

        public ProductSold(Ecommerce ecommerce)
        {
            _ecommerce = ecommerce;
        } 

        public void PaymentDone()
        {
            Console.WriteLine("Please wait, we are already in middle of your request.");
        }

        public void RefundPayment()
        {
            Console.WriteLine("It's too late. We have already processed you request.");
        }

        public void PressConfirm()
        {
            Console.WriteLine("Pressing Confirm twice dosent get you another Product");
            Ship();
        }

        public void Ship()
        {
            Console.WriteLine("Shipping Product to your address....");
            _ecommerce.Stock = _ecommerce.Stock - 1;
            if (_ecommerce.Stock > 0)
            {
                _ecommerce.SetState(new SaleActive(_ecommerce));
            }
            else
            {
                _ecommerce.SetState(new OutOfStock());
            }
        }
    }
}
