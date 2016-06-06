namespace GoF.DesignPattern.Builder
{
    internal class DelhiCheesePizzaBuilder : PizzaBuilder
    {
        public DelhiCheesePizzaBuilder()
        {
            Pizza = new Pizza();
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "Delhi Green Sauce";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = "Capsicum";
        }

        public override void BuildBase()
        {
            Pizza.Base = "Thin Crust";
        }

        public override void BuildName()
        {
            Pizza.Name = "Delhi Cheese Pizza";
        }
    }
}
