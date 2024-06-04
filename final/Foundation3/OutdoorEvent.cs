
public class OutdoorEvent : Event{
    private string _weatherForecast;

    public OutdoorEvent(string title, string description, DateTime date, DateTime time, Address address, string weather) : base(title, description, date, time, address){
        _weatherForecast = weather;
    }

    public string GetFullDetails(){
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public string GetShortDescription()
    {
        return GetShortDescription("Outdoor Gathering");
    }
}