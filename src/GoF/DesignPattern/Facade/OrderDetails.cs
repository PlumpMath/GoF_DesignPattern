namespace GoF.DesignPattern.Facade
{
    internal class OrderDetails
    {
        public string ProductName { get; private set; }
        public int Id { get; private set; }
        public int Discount { get; private set; }
        public double CreditCardNumber { get; private set; }
        public int Price { get; private set; }
        public string ShippingMode { get; private set; }

        public OrderDetails(string productName, int id, int discount, double creditCardNumber, int price, string shippingMode)
        {
            ProductName = productName;
            Id = id;
            Discount = discount;
            CreditCardNumber = creditCardNumber;
            Price = price;
            ShippingMode = shippingMode;
        }
    }
}
