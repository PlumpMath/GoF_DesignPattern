using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class MumbaiPeppypaneerPizza : Pizza
    {
        public MumbaiPeppypaneerPizza()
        {
            Name = "Peppy Paneer";
            Crust = "Thick crust";
            Sauce = "Mumbai Green Sauce";
            Topping = "Paneer";
        }

        public override void Bake()
        {
            Console.WriteLine("Mumbai : Bake for 30 min");
        }
    }
}