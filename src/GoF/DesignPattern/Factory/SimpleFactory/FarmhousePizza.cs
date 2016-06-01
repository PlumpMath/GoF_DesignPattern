namespace GoF.DesignPattern.Factory.SimpleFactory
{
    internal class FarmhousePizza : Pizza
    {
        public FarmhousePizza()
        {
            Name = "Farm House Pizza";
            Crust = "Thick crust";
            Sauce = "Chilly Sauce";
            Topping = "Capsicum";
        }

    }
}
