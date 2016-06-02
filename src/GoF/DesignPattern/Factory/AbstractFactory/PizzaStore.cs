namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal abstract class PizzaStore
    {
        public void OrderPizza(string pizzaName)
        {
            Pizza pizza = CreatePizza(pizzaName);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        public abstract Pizza CreatePizza(string pizzaName);
    }
}
