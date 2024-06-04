
public class ReceptionEvent : Event{
    private string _rsvp;
    public ReceptionEvent(string title, string description, DateTime date, DateTime time, Address address, string rsvp) : base(title, description, date, time, address){
        _rsvp = rsvp;
    }

    public string GetFullDetails(){
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvp}";
    }

    public string GetShortDescription(){
        return GetShortDescription("Reception");
    }
}