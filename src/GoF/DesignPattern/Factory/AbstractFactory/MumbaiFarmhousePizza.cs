using System;

namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class MumbaiFarmhousePizza : Pizza
    {
        public MumbaiFarmhousePizza()
        {
            PizzaIngredients = new MumbaiPizzaIngredients();
            Name = "Farm House Pizza";
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