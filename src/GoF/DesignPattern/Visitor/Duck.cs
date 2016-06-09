namespace GoF.DesignPattern.Visitor
{
    internal abstract class Duck
    {
        public abstract void Fly(IFlyVisitor visitor);

        public abstract void Quack();
    }
}
