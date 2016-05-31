using System;

namespace GoF.DesignPattern.Decorator
{
    internal class FontDecorator : Decorator
    {
        public FontDecorator(DocumentComponent documentComponent) : base(documentComponent)
        {
            Size = 5;
        }

        public override void DisplayDocument()
        {
            DocumentComponent.DisplayDocument();
            Console.WriteLine(" + Font");
        }

        public override int GetSize()
        {
            return DocumentComponent.GetSize() + Size;
        }
    }
}
