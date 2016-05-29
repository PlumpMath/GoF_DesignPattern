using System;
namespace GoF.DesignPattern.Observer
{
    internal class DisplayForecast : IObserver, IDisplay
    {
        private int _temperature;
        private float _humidity;

        public void Update(object[] obj)
        {
            _temperature = (int)obj.GetValue(0);
            _humidity = (float)obj.GetValue(1);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Weather Forcast --> Possiblity of Rain : " + (_humidity>50 ? "Yes":"No"));
        }
    }
}
