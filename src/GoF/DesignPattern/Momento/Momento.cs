namespace GoF.DesignPattern.Momento
{
    internal class Momento
    {
        public int Temperature { get; private set; }
        public int Humidity { get; private set; }
        public string Forecast { get; private set; }

        public Momento(int temperature, int humidity, string forecast)
        {
            Temperature = temperature;
            Humidity = humidity;
            Forecast = forecast;
        }
    }
}
