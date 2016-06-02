using System;
//using GoF.DesignPattern.Factory.FactoryMethod;
using GoF.DesignPattern.Factory.AbstractFactory;

namespace GoF.DesignPattern
{
    internal class FactoryMain
    {
        public static void Main()
        {
            /*
             * Below commented code is for Simple Factory
             * 
             * 
            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();

            Console.WriteLine("1st Pizza --> \n");

            PizzaStore pizzaStore = new PizzaStore(simplePizzaFactory);
            pizzaStore.OrderPizza("cheese");

            Console.WriteLine("\n2nd Pizza --> \n");
            pizzaStore.OrderPizza("farmhouse");
            */

            /*
             * Below commented code is for FactoryMethod
             * 
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
