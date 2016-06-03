namespace GoF.DesignPattern.Command
{
    internal class AcOnCommand : ICommand
    {
        private readonly Ac _ac;
        private readonly int _temperature;

        public AcOnCommand(Ac ac, int temp)
        {
            _ac = ac;
            _temperature = temp;
        }

        public void Execute()
        {
            _ac.PowerOn();
            _ac.SelectTemperature(_temperature);
        }

        public void Undo()
        {
            _ac.PowerOff();
        }
    }
}
