using System;

namespace GoF.DesignPattern.Command
{
    internal class Ac
    {
        public void PowerOn()
        {
            Console.WriteLine("AC ON");
        }

        public void SelectTemperature(int temp)
        {
            Console.WriteLine("Ac set ot temperature : " + temp + " degree");
        }

        public void PowerOff()
        {
            Console.WriteLine("AC OFF");
        }
    }
}
