using System;
using System.Threading;
using GoF.DesignPattern.Observer;

namespace GoF.DesignPattern
{
    internal class ObserverMain
    {
        public static void Main()
        {
            int track = 0;
            WeatherStation weatherStation = new WeatherStation();
            DisplayForecast displayForecast = new DisplayForecast();
            DisplayStatistics displayStatistics = new DisplayStatistics();

            weatherStation.Register(displayStatistics);
            weatherStation.Register(displayForecast);

            do
            {
                weatherStation.SetData(new Random().Next(100), new Random().Next(100));
                track++;
                Thread.Sleep(5000);
            } while (track < 5);
        }
    }
}
