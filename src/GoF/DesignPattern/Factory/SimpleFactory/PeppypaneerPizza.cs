namespace GoF.DesignPattern.Factory.SimpleFactory
{
    internal class PeppypaneerPizza : Pizza
    {
        public PeppypaneerPizza()
        {
            Name = "Peppy Paneer";
            Crust = "Thick crust";
            Sauce = "Green Sauce";
            Topping = "Paneer";
        }
    }
}
