namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class MumbaiPizzaIngredients : IPizzaIngredients
    {
        public Crust CreateCrust()
        {
            return new MumbiCrust();
        }

        public Sauce CreateSauce()
        {
            return new MumbaiSauce();
        }

        public Topping CreateTopping()
        {
            return new MumbaiTopping();
        }
    }
}
