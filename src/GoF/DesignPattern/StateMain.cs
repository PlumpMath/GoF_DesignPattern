using System;
using GoF.DesignPattern.State;

namespace GoF.DesignPattern
{
    internal class StateMain
    {
        public static void Main(string[] args)
        {
            Ecommerce ecommerce = new Ecommerce();
            ecommerce.SetState(new SaleActive(ecommerce));

            Console.WriteLine("Ecommerce Flash Sale - Customer 1");
            ecommerce.MakePayment();
            ecommerce.PressConfirm();

            Console.WriteLine("Ecommerce Flash Sale - Customer 2");
            ecommerce.MakePayment();
            ecommerce.RequestRefund();
            ecommerce.PressConfirm();

            Console.WriteLine("Ecommerce Flash Sale - Customer 3");
            ecommerce.MakePayment();
            ecommerce.PressConfirm();
            ecommerce.MakePayment();
            ecommerce.PressConfirm();
            ecommerce.RequestRefund();

            Console.WriteLine("Ecommerce Flash Sale - Customer 4");
            ecommerce.MakePayment();
            ecommerce.MakePayment();
            ecommerce.PressConfirm();
            ecommerce.MakePayment();
            ecommerce.PressConfirm();
            ecommerce.MakePayment();
            ecommerce.PressConfirm();
        }
    }
}
