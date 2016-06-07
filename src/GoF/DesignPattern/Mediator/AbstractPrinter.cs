namespace GoF.DesignPattern.Mediator
{
    internal abstract class AbstractPrinter
    {
        protected AbstractMediator Mediator;
        public string PrinterType { get; set; }

        public AbstractPrinter(AbstractMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Print(string message, string fromPrinter);
        public abstract void PrintToOtherFormat(string message, string toPrinter, string fromPrinter);
        public abstract void SendAcknowledgement(string toPrinter);
        public abstract void ReceiveAcknowledgement(string fromPrinter);
    }
}
