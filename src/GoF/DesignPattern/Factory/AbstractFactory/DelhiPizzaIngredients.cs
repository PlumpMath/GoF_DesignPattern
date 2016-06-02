namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class DelhiPizzaIngredients : IPizzaIngredients
    {
        public Crust CreateCrust()
        {
            return new DelhiCrust();
        }

        public Sauce CreateSauce()
        {
            return new DelhiSauce();
        }

        public Topping CreateTopping()
        {
            return new DelhiTopping();
        }
    }
}
