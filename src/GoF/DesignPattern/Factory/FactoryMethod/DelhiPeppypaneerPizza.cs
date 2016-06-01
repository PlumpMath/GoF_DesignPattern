using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class DelhiPeppypaneerPizza : Pizza
    {
        public DelhiPeppypaneerPizza()
        {
            Name = "Peppy Paneer";
            Crust = "Thick crust";
            Sauce = "Delhi Green Sauce";
            Topping = "Paneer";
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
