namespace GoF.DesignPattern.Mediator
{
    internal abstract class AbstractMediator
    {
        public abstract void RequestPrint(string message, string toPrinter, string fromPrinter);
        public abstract void AcknowledgePrint(string fromPrinter, string toPrinter);
        public abstract void Register(AbstractPrinter abstractPrinter);
    }
}
