using System;

namespace GoF.DesignPattern.Decorator
{
    internal class TextView : DocumentComponent
    {
        public TextView()
        {
            Size = 5;
        }
        public override void DisplayDocument()
        {
            Console.WriteLine(" + Text");
        }

        public override int GetSize()
        {
            return Size;
        }
    }
}
