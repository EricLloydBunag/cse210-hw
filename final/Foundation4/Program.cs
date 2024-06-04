using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities= new List<Activity>{
            new Running(new DateTime(2024, 5, 30), 30, 3.0),
            new Cycling(new DateTime(2024, 5, 31), 30, 18.0),
            new Swimming(new DateTime(2024, 6, 1), 30, 40)
        };
        
        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}