using System;

namespace GoF.DesignPattern.Command
{
    internal class Light
    {
        public void On()
        {
            Console.WriteLine("Light ON");
        }

        public void Off()
        {
            Console.WriteLine("Light OFF");
        }
    }
}
