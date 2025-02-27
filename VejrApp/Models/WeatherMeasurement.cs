namespace VejrApp.Models
{
    public class WeatherMeasurement
    {
        public double Lon {  get; set; }
        public double Lat { get; set; }
        public double Temp {  get; set; }
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public int Visibility { get; set; }
        public double WindSpeed { get; set; }
        public double WindDeg { get; set; }
        public double WindGust { get; set; }
        public double Cloudyness { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
