namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class MumbaiPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "cheese":
                    return new MumbaiCheesePizza();
                case "peppypaneer":
                    return new MumbaiPeppypaneerPizza();
                case "farmhouse":
                    return new MumbaiFarmhousePizza();
                default:
                    return new MumbaiCheesePizza();
            }
        }
    }
}
