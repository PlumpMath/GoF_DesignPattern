using System;

namespace GoF.DesignPattern.Bridge
{
    internal class InBuiltApi : IApis
    {
        public void DoCommunication(string message)
        {
            Console.WriteLine("Used in-built API to send Message : " + message);
        }
    }
}
