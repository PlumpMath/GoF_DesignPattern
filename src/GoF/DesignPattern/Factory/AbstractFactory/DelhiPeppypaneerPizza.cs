using System;

namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class DelhiPeppypaneerPizza : Pizza
    {
        public DelhiPeppypaneerPizza()
        {
            PizzaIngredients = new DelhiPizzaIngredients();
            Name = "Peppy Paneer";
            Crust = PizzaIngredients.CreateCrust().GetCrust();
            Sauce = PizzaIngredients.CreateSauce().GetSauce();
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
