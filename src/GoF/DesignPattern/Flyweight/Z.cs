using System;

namespace GoF.DesignPattern.Flyweight
{
    internal class Z : IFlyweight
    {
        public string Symbol { get; private set; }
        public int AsciValue { get; private set; }

        public Z()
        {
            Symbol = "Z";
            AsciValue = 90;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine("Character symbol '" + Symbol + "' and ASCI value " + AsciValue + " drawn at coordinates (" + x + "," + y + ")");
        }
    }
}
