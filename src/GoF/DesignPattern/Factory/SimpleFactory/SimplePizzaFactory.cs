namespace GoF.DesignPattern.Factory.SimpleFactory
{
    internal class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "cheese":
                    return new CheesePizza();
                case "peppypaneer":
                    return new PeppypaneerPizza();
                case "farmhouse":
                    return new FarmhousePizza();
                default:
                    return new CheesePizza();
            }
        }
    }
}
