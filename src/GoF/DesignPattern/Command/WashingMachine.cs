using System;

namespace GoF.DesignPattern.Command
{
    internal class WashingMachine
    {
        public void PowerOn()
        {
            Console.WriteLine("Washing machine ON");
        }

        public void FillWater(int liters)
        {
            Console.WriteLine("Filling water : " + liters + " ltrs");
        }

        public void PerformWashing()
        {
            Console.WriteLine("Washing clothes");
        }

        public void Drain()
        {
            Console.WriteLine("Draining leftover water");
        }

        public void PowerOff()
        {
            Console.WriteLine("Washing machine off");
        }
    }
}
