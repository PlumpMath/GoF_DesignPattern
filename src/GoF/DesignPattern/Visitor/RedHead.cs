using System;

namespace GoF.DesignPattern.Visitor
{
    internal class RedHead : Duck
    {
        public override void Fly(IFlyVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Quack()
        {
            Console.WriteLine("RedHead duck Quack : MMHHH QQQuack");
        }
    }
}
