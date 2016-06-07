using System.Collections.Generic;

namespace GoF.DesignPattern.Mediator
{
    internal class Mediator : AbstractMediator
    {
        private readonly Dictionary<string, AbstractPrinter> _dictionary;

        public Mediator()
        {
            _dictionary = new Dictionary<string, AbstractPrinter>();
        }

        public override void RequestPrint(string message, string toPrinter, string fromPrinter)
        {
            _dictionary[toPrinter].Print(message, fromPrinter);
        }

        public override void AcknowledgePrint(string fromPrinter, string toPrinter)
        {
            _dictionary[toPrinter].ReceiveAcknowledgement(fromPrinter);
        }

        public override void Register(AbstractPrinter abstractPrinter)
        {
            _dictionary.Add(abstractPrinter.PrinterType, abstractPrinter);
        }
    }
}
