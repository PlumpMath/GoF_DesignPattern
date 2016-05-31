namespace GoF.DesignPattern.Decorator
{
    internal abstract class DocumentComponent
    {
        protected int Size = 0;

        public abstract void DisplayDocument();
        public abstract int GetSize();
    }
}
