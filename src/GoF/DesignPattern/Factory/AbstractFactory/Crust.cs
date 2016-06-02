namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal abstract class Crust
    {
        protected string CrustType;

        public string GetCrust()
        {
            return CrustType;
        }
    }
}
