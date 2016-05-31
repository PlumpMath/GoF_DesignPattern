using System;

namespace GoF.DesignPattern.Decorator
{
    internal class BorderDecorator : Decorator
    {
        public BorderDecorator(DocumentComponent documentComponent) : base(documentComponent)
        {
            Size = 1;
        }

        public override void DisplayDocument()
        {
            DocumentComponent.DisplayDocument();
            Console.WriteLine(" + Border");
        }

        public override int GetSize()
        {
            return DocumentComponent.GetSize() + Size;
        }
    }
}
