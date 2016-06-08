using System;
using GoF.DesignPattern.Flyweight;

namespace GoF.DesignPattern
{
    internal class FlyweightMain
    {
        public static void Main(string[] args)
        {
            string text = "ABZBZA";
            Console.WriteLine("Data in file : " + text);

            Char[] chars = text.ToCharArray();

            FlyweightFactory factory = new FlyweightFactory();

            Console.WriteLine("We will print the data to a new file at location (10,20).....");
            foreach (var c in chars)
            {
                factory.GetFlyweight(c).Draw(10, 20);
            }
        }
    }
}
