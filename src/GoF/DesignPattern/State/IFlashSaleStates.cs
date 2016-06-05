namespace GoF.DesignPattern.State
{
    internal interface IFlashSaleStates
    {
        void PaymentDone();
        void RefundPayment();
        void PressConfirm();
        void Ship();
    }
}
