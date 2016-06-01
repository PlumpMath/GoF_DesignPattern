using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class DelhiFarmhousePizza : Pizza
    {
        public DelhiFarmhousePizza()
        {
            Name = "Farm House Pizza";
            Crust = "Thick crust";
            Sauce = "Delhi Chilly Sauce";
            Topping = "Capsicum";
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
