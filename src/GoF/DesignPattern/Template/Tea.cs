using System;

namespace GoF.DesignPattern.Template
{
    internal class Tea : Beverage
    {
        public override void AddIngredients()
        {
            Console.WriteLine("Add Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Brew it with Tea Leaves");
        }
    }
}
