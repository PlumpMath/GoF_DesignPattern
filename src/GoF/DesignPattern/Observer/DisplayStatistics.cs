using System;

namespace GoF.DesignPattern.Observer
{
    internal class DisplayStatistics : IObserver, IDisplay
    {
        private int _temperature;
        private float _humidity;

        public void Update(object[] obj)
        {
            _temperature = (int)obj.GetValue(0);
            _humidity = (float) obj.GetValue(1);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Weather Statistics --> " + _temperature + " ^ celcius & " + _humidity + " % humidity");
        }
    }
}
