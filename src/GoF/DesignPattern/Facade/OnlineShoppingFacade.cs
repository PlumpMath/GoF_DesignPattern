namespace GoF.DesignPattern.Facade
{
    internal class OnlineShoppingFacade
    {
        private readonly Inventory _inventory;
        private readonly Payment _payment;
        private readonly Address _address;
        private readonly Discount _discount;
        private readonly Shipping _shipping;

        public OnlineShoppingFacade(Inventory inventory, Payment payment, Address address, Discount discount, Shipping shipping)
        {
            _inventory = inventory;
            _payment = payment;
            _address = address;
            _discount = discount;
            _shipping = shipping;
        }

        public void FinalizeOrder(OrderDetails orderDetails)
        {
            _inventory.IsProductAvailable(orderDetails.Id);
            _inventory.GetProduct(orderDetails.Id, 1);
            _discount.ApplyDiscount(orderDetails.Price, 10);
            _payment.VerifyCreditCard(orderDetails.CreditCardNumber);
            _payment.PerformTransaction(orderDetails.CreditCardNumber, orderDetails.Price);
            _address.GetAddress("Chirag");
            _shipping.InitiateShipping(orderDetails.ShippingMode, orderDetails.Id);
        }

        public void ReturnOrder(OrderDetails orderDetails)
        {
            //......
        }

        //....
    }
}
