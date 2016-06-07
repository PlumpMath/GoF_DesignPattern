using System;

namespace GoF.DesignPattern.Mediator
{
    internal class XmlPrinter : AbstractPrinter
    {
        public XmlPrinter(AbstractMediator mediator) : base(mediator)
        {
            PrinterType = "XML";
        }

        public override void Print(string message, string fromPrinter)
        {
            Console.WriteLine("XML : " + message);
            this.SendAcknowledgement(fromPrinter);
        }

        public override void PrintToOtherFormat(string message, string toPrinter, string fromPrinter)
        {
            Mediator.RequestPrint(message, toPrinter, fromPrinter);
        }

        public override void SendAcknowledgement(string toPrinter)
        {
            Mediator.AcknowledgePrint(this.PrinterType, toPrinter);
        }

        public override void ReceiveAcknowledgement(string fromPrinter)
        {
            Console.WriteLine(fromPrinter + " : Print successfull");
        }
    }
}
