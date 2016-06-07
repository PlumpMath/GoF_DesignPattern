using System;

namespace GoF.DesignPattern.Mediator
{
    internal class HtmlPrinter : AbstractPrinter
    {
        public HtmlPrinter(AbstractMediator mediator) : base(mediator)
        {
            PrinterType = "HTML";
        }

        public override void Print(string message, string fromPrinter)
        {
            Console.WriteLine("HTML : " + message);
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
