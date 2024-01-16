namespace Weather_and_News.Models
{
    public class OpenWeatherResponse
    {
        public string Name { get; set; } // City name
        public MainData Main { get; set; }
        public List<WeatherData> Weather { get; set; }
        public WindData Wind { get; set; } 
        public int Humidity { get; set; } 
        public int Pressure { get; set; } 
    }

    public class MainData
    {
        public float Temp { get; set; } 
        public int Humidity { get; set; } 
        public int Pressure { get; set; } 
    }

    public class WeatherData
    {
        public string Description { get; set; } 
    }

    public class WindData
    {
        public float Speed { get; set; } 
    }
}
