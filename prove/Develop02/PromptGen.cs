public class PromptGen{
    string _entryPrompt;
    public string[] _prompts =  
        {"What is one thing I`m thankful for today?", 
        "What was the most fun thing I did today?", 
        "Who was the most interesting person I met today?",
        "What are some of today's highlights for me?",
        "What new thing did I learn today?",
        "How did I see the hand of the Lord in my life today?"};
    Random randPrompt = new Random();

    public string GetRandomPrompt(){
    _entryPrompt = _prompts[randPrompt.Next(_prompts.Length)];
    return _entryPrompt;
    }
}

