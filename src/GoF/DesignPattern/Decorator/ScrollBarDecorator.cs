using System;

namespace GoF.DesignPattern.Decorator
{
    internal class ScrollBarDecorator : Decorator
    {
        public ScrollBarDecorator(DocumentComponent documentComponent) : base(documentComponent)
        {
            Size = 2;
        }

        public override void DisplayDocument()
        {
            DocumentComponent.DisplayDocument();
            Console.WriteLine(" + ScrollBar");
        }

        public override int GetSize()
        {
            return DocumentComponent.GetSize() + Size;
        }
    }
}
