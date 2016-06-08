using System;

namespace GoF.DesignPattern.Bridge
{
    internal class Email : Communication
    {
        public Email(IApis api) : base(api)
        {
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("Sending Email");
            Api.DoCommunication(message);
        }
    }
}
