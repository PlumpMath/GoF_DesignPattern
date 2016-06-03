namespace GoF.DesignPattern.Command
{
    internal class AcOffCommand : ICommand
    {
        private readonly Ac _ac;
        private readonly int _temperature;

        public AcOffCommand(Ac ac, int temp)
        {
            _ac = ac;
            _temperature = temp;
        }

        public void Execute()
        {
            _ac.PowerOff();
        }

        public void Undo()
        {
            _ac.PowerOn();
            _ac.SelectTemperature(_temperature);
        }
    }
}
