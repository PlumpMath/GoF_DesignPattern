using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class MumbaiFarmhousePizza : Pizza
    {
        public MumbaiFarmhousePizza()
        {
            Name = "Farm House Pizza";
            Crust = "Thick crust";
            Sauce = "Mumbai Chilly Sauce";
            Topping = "Capsicum";
        }

        public override void Bake()
        {
            Console.WriteLine("Mumbai : Bake for 30 min");
        }
    }
}