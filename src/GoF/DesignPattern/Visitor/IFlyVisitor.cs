namespace GoF.DesignPattern.Visitor
{
    internal interface IFlyVisitor
    {
        void Visit(Mallard mallard);
        void Visit(RedHead redHead);
    }
}
