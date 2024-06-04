
public class LectureEvent : Event{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetShortDescription()
    {
        return GetShortDescription("Lecture");
    }
}