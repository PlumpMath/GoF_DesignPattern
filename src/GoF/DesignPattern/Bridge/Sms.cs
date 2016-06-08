using System;

namespace GoF.DesignPattern.Bridge
{
    internal class Sms : Communication
    {
        public Sms(IApis api) : base(api)
        {
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("Sending SMS");
            Api.DoCommunication(message);
        }
    }
}
