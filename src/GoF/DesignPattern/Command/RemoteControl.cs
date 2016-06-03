namespace GoF.DesignPattern.Command
{
    internal class RemoteControl
    {
        private ICommand[] onSlots = new ICommand[5];
        private ICommand[] offSlots = new ICommand[5];
        private ICommand undoCommand;

        public RemoteControl()
        {
            for (var i = 0; i < 5; i++)
            {
                onSlots[i] = new EmptyCommand();
                offSlots[i] = new EmptyCommand();
                undoCommand = new EmptyCommand();
            }
        }

        public void SetCommand(int index, ICommand onCommand, ICommand offCommand)
        {
            onSlots[index] = onCommand;
            offSlots[index] = offCommand;
        }

        public void ButtonOnPressed(int index)
        {
            onSlots[index].Execute();
            undoCommand = onSlots[index];
        }

        public void ButtonOffPressed(int index)
        {
            offSlots[index].Execute();
            undoCommand = offSlots[index];
        }

        public void UndoButtonPressed()
        {
            undoCommand.Undo();
        }
    }
}
