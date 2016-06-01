using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class MumbaiCheesePizza : Pizza
    {
        public MumbaiCheesePizza()
        {
            Name = "Cheese Pizza";
            Sauce = "Mumbai Red Sauce";
            Crust = "Thin Crust";
            Topping = "Mozarella Cheese";
        }

        public override void Bake()
        {
            Console.WriteLine("Mumbai : Bake for 30 min");
        }
    }
}