namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal abstract class Sauce
    {
        protected string SauceType;

        public string GetSauce()
        {
            return SauceType;
        }
    }
}
