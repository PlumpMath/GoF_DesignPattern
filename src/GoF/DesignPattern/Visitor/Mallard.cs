using System;

namespace GoF.DesignPattern.Visitor
{
    internal class Mallard : Duck
    {
        public override void Fly(IFlyVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Quack()
        {
            Console.WriteLine("Mallard duck Quack :  QQQQ Quack");
        }
    }
}
