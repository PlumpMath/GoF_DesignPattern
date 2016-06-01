namespace GoF.DesignPattern.Factory.SimpleFactory
{
    internal class PizzaStore
    {
        private readonly SimplePizzaFactory _simplePizzaFactory;

        public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        {
            this._simplePizzaFactory = simplePizzaFactory;
        }

        public void OrderPizza(string pizzaName)
        {
            /* The code commented below is tightly coupled and breaks the OCP */

            //if (pizzaName == "cheese")
            //{
            //    _pizaa = new CheesePizza();
            //}
            //if (pizzaName == "peppypaneer")
            //{
            //    _pizaa = new PeppypaneerPizza();
            //}
            //if (pizzaName == "farmhouse")
            //{
            //    _pizaa = new FarmhousePizza();
            //}

            Pizza pizza = _simplePizzaFactory.CreatePizza(pizzaName);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
