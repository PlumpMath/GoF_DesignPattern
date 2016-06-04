using System;

namespace GoF.DesignPattern.Template
{
    internal class Coffee : Beverage
    {
        public override void AddIngredients()
        {
            Console.WriteLine("Add Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Brew it with coffee beans");
        }
    }
}
