using System;

namespace GoF.DesignPattern.Decorator
{
    internal class HeaderAndFooterDecorator : Decorator
    {
        public HeaderAndFooterDecorator(DocumentComponent documentComponent) : base(documentComponent)
        {
            Size = 4;
        }

        public override void DisplayDocument()
        {
            DocumentComponent.DisplayDocument();
            Console.WriteLine(" + HeaderAndFooter");
        }

        public override int GetSize()
        {
            return DocumentComponent.GetSize() + Size;
        }
    }
}
