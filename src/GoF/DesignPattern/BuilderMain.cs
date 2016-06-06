using GoF.DesignPattern.Builder;

namespace GoF.DesignPattern
{
    internal class BuilderMain
    {
        public static void Main(string[] args)
        {
            PizzaBuilder delhiPizzaBuilder = new DelhiCheesePizzaBuilder();
            PizzaBuilder mumbaiPizzaBuilder = new MumbaiCheesePizzaBuilder();

            Cook cook = new Cook();

            cook.PreparePizza(delhiPizzaBuilder);
            delhiPizzaBuilder.GetPizza().ShowPizza();

            cook.PreparePizza(mumbaiPizzaBuilder);
            mumbaiPizzaBuilder.GetPizza().ShowPizza();
        }
    }
}
