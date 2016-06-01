namespace GoF.DesignPattern.Factory.SimpleFactory
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Sauce = "Red Sauce";
            Crust = "Thin Crust";
            Topping = "Mozarella Cheese";
        }
    }
}
