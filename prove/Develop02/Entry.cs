
public class Entry{
    DateTime currentDate = DateTime.Now;
    PromptGen prompt = new PromptGen();  
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _promptAnswer {get; set;}
    public string _userEntry;


    public string WriteEntry(){
    _date = currentDate.ToString("MMMM dd, yyyy - dddd");

    _promptText = prompt.GetRandomPrompt();

    Console.WriteLine($"{_promptText} \n");

    _promptAnswer = Console.ReadLine();

    _userEntry = $"{_date} \nPrompt: {_promptText} \n{_promptAnswer}\n";

    return _userEntry;
    }

    public void Display(){
        Console.WriteLine(_userEntry);
    }
}