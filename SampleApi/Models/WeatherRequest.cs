namespace SampleApi.Models;

public class WeatherRequest
{
    public string City { get; set; } = string.Empty;
    public int Temperature { get; set; }
}
