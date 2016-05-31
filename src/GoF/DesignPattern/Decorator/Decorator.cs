namespace GoF.DesignPattern.Decorator
{
    internal abstract class Decorator : DocumentComponent
    {
        protected DocumentComponent DocumentComponent;

        protected Decorator(DocumentComponent documentComponent)
        {
            DocumentComponent = documentComponent;
        }
        public abstract override void DisplayDocument();

        public abstract override int GetSize();
    }
}
