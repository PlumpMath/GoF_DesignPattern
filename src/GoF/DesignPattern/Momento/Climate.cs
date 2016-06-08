namespace GoF.DesignPattern.Momento
{
    internal class Climate
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string Forecast { get; set; }

        public void SetMomento(Momento momento)
        {
            Temperature = momento.Temperature;
            Humidity = momento.Humidity;
            Forecast = momento.Forecast;
        }

        public Momento CreateMomento()
        {
            return new Momento(Temperature, Humidity, Forecast);
        }

    }
}
