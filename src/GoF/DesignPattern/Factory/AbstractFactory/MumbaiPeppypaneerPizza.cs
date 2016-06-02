using System;

namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class MumbaiPeppypaneerPizza : Pizza
    {
        public MumbaiPeppypaneerPizza()
        {
            PizzaIngredients = new MumbaiPizzaIngredients();
            Name = "Peppy Paneer";
            Crust = PizzaIngredients.CreateCrust().GetCrust();
            Sauce = PizzaIngredients.CreateSauce().GetSauce();
            Topping = PizzaIngredients.CreateTopping().GetTopping();
        }

        public override void Bake()
        {
            Console.WriteLine("Mumbai : Bake for 30 min");
        }
    }
}