namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal abstract class Topping
    {
        protected string ToppingName;

        public string GetTopping()
        {
            return ToppingName;
        }
    }
}
