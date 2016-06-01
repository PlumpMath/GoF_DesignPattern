using System;
using GoF.DesignPattern.Factory.FactoryMethod;

namespace GoF.DesignPattern
{
    internal class FactoryMain
    {
        public static void Main()
        {
            /*
             * Following code is for Simple Factory
             * 
             * 
            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();

            Console.WriteLine("1st Pizza --> \n");

            PizzaStore pizzaStore = new PizzaStore(simplePizzaFactory);
            pizzaStore.OrderPizza("cheese");

            Console.WriteLine("\n2nd Pizza --> \n");
            pizzaStore.OrderPizza("farmhouse");
            */

            Console.WriteLine("1st Pizza --> \n");

            PizzaStore mumbaiPizzaStore = new MumbaiPizzaStore();
            mumbaiPizzaStore.OrderPizza("farmhouse");

            Console.WriteLine("\n2nd Pizza --> \n");

            PizzaStore delhiPizzaStore = new DelhiPizzaStore();
            delhiPizzaStore.OrderPizza("peppypaneer");
        }
    }
}
