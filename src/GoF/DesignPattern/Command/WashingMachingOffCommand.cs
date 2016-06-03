namespace GoF.DesignPattern.Command
{
    internal class WashingMachingOffCommand : ICommand
    {
        private readonly WashingMachine _washingMachine;
        private readonly int _liters;

        public WashingMachingOffCommand(WashingMachine washingMachine, int liters)
        {
            _washingMachine = washingMachine;
            _liters = liters;
        }
        public void Execute()
        {
            _washingMachine.Drain();
            _washingMachine.PowerOff();
        }

        public void Undo()
        {
            _washingMachine.PowerOn();
            _washingMachine.FillWater(_liters);
            _washingMachine.PerformWashing();
        }
    }
}
