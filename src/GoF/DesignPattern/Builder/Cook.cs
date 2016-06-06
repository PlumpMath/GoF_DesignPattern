namespace GoF.DesignPattern.Builder
{
    internal class Cook
    {
        public void PreparePizza(PizzaBuilder builder)
        {
            builder.BuildBase();
            builder.BuildSauce();
            builder.BuildTopping();
            builder.BuildName();
        }
    }
}
