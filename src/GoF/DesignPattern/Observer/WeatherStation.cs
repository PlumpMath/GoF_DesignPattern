using System.Collections.Generic;

namespace GoF.DesignPattern.Observer
{
    /// <summary>
    /// AccuWeather wants us to develop an anpp for them. The app should provides the user with the real time weather data(forecast, statistics....).
    /// AccuWeather will provide an API(WeatherStation) which featches the data from the real devices. Our aim is to take the data provided by API and use it in building our application. Also the data provided by an API is updated at regular intervals and our application should be updated with the latest data all the time.
    /// Since we do not have a real device here for the API to cumunicate with, we will provide dummy data to the API to test our purpose.
    /// AccuWeather has informed that <see cref="WeatherDataUpdated"/> method will be called whenever the data updates.
    /// </summary>
    internal class WeatherStation : IObservable
    {
        public int Temperature { get; private set; }
        public float Humidity { get; private set; }
        private readonly List<IObserver> _observers;
        public WeatherStation()
        {
            _observers = new List<IObserver>();
            StartPolling();
        }

        private void GetTempFromThermometer()
        {
            // some code which gets temp from thermometer device at specific intervals. It sets the Temperature property.
        }

        private void GetHumidityFromHygrometer()
        {
            // some code which gets Humidity from Hygrometer device at specific intervals. It sets the Humidity property.
        }

        private void StartPolling()
        {
            // This method creates a background thread that will run continuously and will command to fetch data from the device at specific interval, lets say 1 hr.

            // from the thread calling ---> 
            GetTempFromThermometer();
            GetHumidityFromHygrometer();
            // WeatherDataUpdated();
        }

        private void WeatherDataUpdated()
        {
            foreach (var observer in _observers)
            {
                observer.Update(new object[] { Temperature, Humidity });
            }
        }

        // Since we do not have the device we will set the data by providing in values in this method call.
        public void SetData(int temperature, float humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
            WeatherDataUpdated();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
