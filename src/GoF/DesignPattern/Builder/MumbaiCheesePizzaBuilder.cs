namespace GoF.DesignPattern.Builder
{
    internal class MumbaiCheesePizzaBuilder : PizzaBuilder
    {
        public MumbaiCheesePizzaBuilder()
        {
            Pizza = new Pizza();
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "Mumbai Red Sauce";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = "Tomatoes";
        }

        public override void BuildBase()
        {
            Pizza.Base = "Pan Crust";
        }

        public override void BuildName()
        {
            Pizza.Name = "Mumbai Cheese Pizza";
        }
    }
}
