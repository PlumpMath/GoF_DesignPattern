namespace GoF.DesignPattern.Command
{
    internal class WashingMachingOnCommand : ICommand
    {
        private readonly WashingMachine _washingMachine;
        private readonly int _liters;

        public WashingMachingOnCommand(WashingMachine washingMachine, int liters)
        {
            _washingMachine = washingMachine;
            _liters = liters;
        }
        public void Execute()
        {
            _washingMachine.PowerOn();
            _washingMachine.FillWater(_liters);
            _washingMachine.PerformWashing();
        }

        public void Undo()
        {
            _washingMachine.Drain();
            _washingMachine.PowerOff();
        }
    }
}
