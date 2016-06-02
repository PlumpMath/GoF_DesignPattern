using System;

namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class DelhiCheesePizza : Pizza
    {
        public DelhiCheesePizza()
        {
            PizzaIngredients = new DelhiPizzaIngredients();
            Name = "Cheese Pizza";
            Sauce = PizzaIngredients.CreateSauce().GetSauce();
            Crust = PizzaIngredients.CreateCrust().GetCrust();
            Topping = PizzaIngredients.CreateTopping().GetTopping();
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
