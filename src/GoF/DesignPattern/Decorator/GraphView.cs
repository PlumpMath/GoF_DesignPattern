using System;

namespace GoF.DesignPattern.Decorator
{
    internal class GraphView : DocumentComponent
    {
        public GraphView()
        {
            Size = 10;
        }
        public override void DisplayDocument()
        {
            Console.WriteLine(" + Graph");
        }

        public override int GetSize()
        {
            return Size;
        }
    }
}
