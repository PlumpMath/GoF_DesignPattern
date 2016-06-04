using GoF.DesignPattern.Facade;

namespace GoF.DesignPattern
{
    internal class FacadeMain
    {
        public static void Main(string[] args)
        {
            OrderDetails orderDetails = new OrderDetails("Skullcandy In-ear", 245789854, 10, 1523987451288731, 999, "Air");

            OnlineShoppingFacade shoppingFacade = new OnlineShoppingFacade(new Inventory(), new Payment(), new Address(), new Discount(), new Shipping());
            shoppingFacade.FinalizeOrder(orderDetails);
        }
    }
}
