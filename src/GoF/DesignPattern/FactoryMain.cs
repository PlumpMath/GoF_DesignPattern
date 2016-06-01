using System;
using GoF.DesignPattern.Factory.SimpleFactory;

namespace GoF.DesignPattern
{
    internal class FactoryMain
    {
        public static void Main()
        {
            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();

            Console.WriteLine("1st Pizza --> \n");

            PizzaStore pizzaStore = new PizzaStore(simplePizzaFactory);
            pizzaStore.OrderPizza("cheese");

            Console.WriteLine("\n2nd Pizza --> \n");
            pizzaStore.OrderPizza("farmhouse");
        }
    }
}
