using System;

namespace GoF.DesignPattern.Bridge
{
    internal class ThirdPartyApi : IApis
    {
        public void DoCommunication(string message)
        {
            Console.WriteLine("Used Third party API to send Message : " + message);
        }
    }
}
