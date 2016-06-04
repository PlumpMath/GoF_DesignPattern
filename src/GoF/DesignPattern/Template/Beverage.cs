using System;

namespace GoF.DesignPattern.Template
{
    internal abstract class Beverage
    {
        // Template Method
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PutInCup();
            AddIngredients();
        }

        public abstract void AddIngredients();

        public abstract void Brew();

        private void PutInCup()
        {
            Console.WriteLine("Empty the contents in Cup");
        }

        private void BoilWater()
        {
            Console.WriteLine("Put water to Boil");
        }
    }
}
