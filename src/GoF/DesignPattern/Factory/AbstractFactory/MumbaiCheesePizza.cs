using System;

namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class MumbaiCheesePizza : Pizza
    {
        public MumbaiCheesePizza()
        {
            PizzaIngredients = new MumbaiPizzaIngredients();
            Name = "Cheese Pizza";
            Sauce = PizzaIngredients.CreateSauce().GetSauce();
            Crust = PizzaIngredients.CreateCrust().GetCrust();
            Topping = PizzaIngredients.CreateTopping().GetTopping();
        }

        public override void Bake()
        {
            Console.WriteLine("Mumbai : Bake for 30 min");
        }
    }
}