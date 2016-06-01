using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class DelhiCheesePizza : Pizza
    {
        public DelhiCheesePizza()
        {
            Name = "Cheese Pizza";
            Sauce = "Delhi Red Sauce";
            Crust = "Thin Crust";
            Topping = "Mozarella Cheese";
        }

        public override void Bake()
        {
            Console.WriteLine("Delhi : Bake for 45 min");
        }

        public override void Cut()
        {
            Console.WriteLine("Delhi : Cut into 8 pics");
        }
    }
}
