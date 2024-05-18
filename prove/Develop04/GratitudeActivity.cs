class GratitudeActivity : MindfulnessActivity
{
    private string[] prompts = 
    {
        "Think about a person you are grateful for.",
        "Think about a recent experience that made you happy.",
        "Think about something in your life that you often take for granted.",
        "Think about a skill or talent you have that you are thankful for."
    };

    private string[] questions = 
    {
        "Why is this person or experience meaningful to you?",
        "How does this make you feel?",
        "What impact does this have on your life?",
        "How can you show your gratitude for this?",
        "What would your life be like without this?"
    };

    public GratitudeActivity()
    {
        _actName = "Gratitude";
        _actDesc = "This activity will help you reflect on things you are grateful for in your life. This will help you appreciate the positive aspects of your life.";
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            PauseDots(5);
        }
        End();
    }
}
