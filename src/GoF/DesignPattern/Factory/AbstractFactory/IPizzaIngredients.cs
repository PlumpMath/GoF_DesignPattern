namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal interface IPizzaIngredients
    {
        Crust CreateCrust();
        Sauce CreateSauce();
        Topping CreateTopping();
    }
}
