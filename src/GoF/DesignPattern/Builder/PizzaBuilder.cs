namespace GoF.DesignPattern.Builder
{
    internal abstract class PizzaBuilder
    {
        protected Pizza Pizza;

        public Pizza GetPizza()
        {
            return Pizza;
        }

        public abstract void BuildSauce();
        public abstract void BuildTopping();
        public abstract void BuildBase();
        public abstract void BuildName();

    }
}
