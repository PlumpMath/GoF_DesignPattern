using System;

namespace GoF.DesignPattern.Visitor
{
    internal class RocketFly : IFlyVisitor
    {
        public void Visit(Mallard mallard)
        {
            Console.WriteLine("Mallard Duck is flying like a rocket");
        }

        public void Visit(RedHead redHead)
        {
            Console.WriteLine("RedHead Duck is flying like a rocket");
        }
    }
}
