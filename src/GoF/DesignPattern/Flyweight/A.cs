using System;

namespace GoF.DesignPattern.Flyweight
{
    internal class A : IFlyweight
    {
        public string Symbol { get; private set; }
        public int AsciValue { get; private set; }

        public A()
        {
            Symbol = "A";
            AsciValue = 65;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine("Character symbol '" + Symbol + "' and ASCI value "+ AsciValue + " drawn at coordinates (" + x + "," + y + ")");
        }
    }
}
