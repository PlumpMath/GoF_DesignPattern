using System;
using GoF.DesignPattern.Momento;

namespace GoF.DesignPattern
{
    internal class MomentoMain
    {
        public static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();

            Climate climate = new Climate();
            climate.Temperature = 35;
            climate.Humidity = 85;
            climate.Forecast = "Windy";
            Console.WriteLine("Whether at start of day --> " + "Temperature : " + climate.Temperature + ", Humidity : " + climate.Humidity + ", Forecast : " + climate.Forecast);

            careTaker.Momento = climate.CreateMomento();

            climate.Temperature = 45;
            climate.Humidity = 65;
            climate.Forecast = "Sunny";
            Console.WriteLine("Whether in the afternoon --> " + "Temperature : " + climate.Temperature + ", Humidity : " + climate.Humidity + ", Forecast : " + climate.Forecast);

            Console.WriteLine("\nRestoring whether data to start of day.....\n");

            climate.SetMomento(careTaker.Momento);
            Console.WriteLine("Temperature : " + climate.Temperature + ", Humidity : " + climate.Humidity + ", Forecast : " + climate.Forecast);
        }
    }
}
