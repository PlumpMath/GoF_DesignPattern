using System;

namespace GoF.DesignPattern.Visitor
{
    internal class ZigZagFly : IFlyVisitor
    {
        public void Visit(Mallard mallard)
        {
            Console.WriteLine("Mallard duck can fly like Zig-Zag");

        }

        public void Visit(RedHead redHead)
        {
            Console.WriteLine("RedHead duck can fly like a Zig-Zag");
        }
    }
}
