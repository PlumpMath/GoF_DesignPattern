using System;
using GoF.DesignPattern.Factory.AbstractFactory;

namespace GoF.DesignPattern.Builder
{
    internal class Pizza
    {
        public string Sauce { get; set; }
        public string Topping { get; set; }
        public string Base { get; set; }
        public string Name { get; set; }

        public void ShowPizza()
        {
            Console.WriteLine(Name + " --> Base : " + Base + ", Sauce : " + Sauce + ", Topping : " + Topping);
        }
    }
}
