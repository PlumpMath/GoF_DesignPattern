namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class DelhiPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "cheese":
                    return new DelhiCheesePizza();
                case "peppypaneer":
                    return new DelhiPeppypaneerPizza();
                case "farmhouse":
                    return new DelhiFarmhousePizza();
                default:
                    return new DelhiCheesePizza();
            }   
        }
    }
}
