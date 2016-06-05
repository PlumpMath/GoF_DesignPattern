namespace GoF.DesignPattern.State
{
    /// <summary>
    /// One of a kind flash sale where customer makes the payement first and then decides to proceed with the purchase or ask for refund. To proceeds with the request, customer presses the Confirm button which is same as calling ProcessItem() method.
    /// </summary>
    internal class Ecommerce
    {
        private IFlashSaleStates _saleStates;
        public int Stock { get; set; }

        public Ecommerce()
        {
            _saleStates = new OutOfStock();
            Stock = 5;

        }

        public void SetState(IFlashSaleStates state)
        {
            _saleStates = state;
        }

        public void MakePayment()
        {
            _saleStates.PaymentDone();
        }

        public void RequestRefund()
        {
            _saleStates.RefundPayment();
        }

        public void PressConfirm()
        {
            _saleStates.PressConfirm();
        }

        public void Ship()
        {
            _saleStates.Ship();
        }
    }
}
