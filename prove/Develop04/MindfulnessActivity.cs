public abstract class MindfulnessActivity
{
    protected string _actName;
    protected string _actDesc;
    protected int _duration;

    protected void Start()
    {
        Console.WriteLine($"Starting {_actName} Activity");
        Console.WriteLine(_actDesc);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_actName} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds){
    int sec = seconds;
    do{
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        sec--;        
        }   while(sec > 0);
    }

    protected void PauseDots(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}