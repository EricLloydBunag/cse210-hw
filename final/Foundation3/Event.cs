public class Event{
    protected string _eventTitle;
    protected string _eventDesc;
    protected DateTime _eventDate;
    protected DateTime _eventTime;
    protected Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address){
        _eventTitle = title;
        _eventDesc = description;
        _eventDate = date;
        _eventTime = time;
        _address = address;
    }

    public string GetStandardDetails(){
        return $"{_eventTitle} - {_eventDate}, {_eventTime} at {_address.GetAddress()}\n{_eventDesc}";
    }
    
    public string GetShortDescription(string eventType){
        return $"{eventType}: {_eventTitle} on {_eventDate.ToShortDateString()}";
    }

}