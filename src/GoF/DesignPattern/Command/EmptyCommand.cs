namespace GoF.DesignPattern.Command
{
    internal class EmptyCommand : ICommand
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
