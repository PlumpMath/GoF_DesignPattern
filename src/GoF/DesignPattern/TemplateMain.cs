using System;
using GoF.DesignPattern.Template;

namespace GoF.DesignPattern
{
    internal class TemplateMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Preparing Coffee -->\n");
            Beverage coffee = new Coffee();
            coffee.PrepareBeverage();

            Console.WriteLine("\nPreparing Tea -->\n");
            Beverage tea = new Tea();
            tea.PrepareBeverage();
        }
    }
}
