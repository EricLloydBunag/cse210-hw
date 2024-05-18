class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _actName = "Breathing";
        _actDesc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        Start();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseDots(3);
            Console.WriteLine("Breathe out...");
            PauseDots(3);
        }
        End();
    }
}