namespace GoF.DesignPattern.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
