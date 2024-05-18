class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Gratitude");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            MindfulnessActivity activity;

            do{
            if (choice == "1"){
                activity = new BreathingActivity();
                activity.Run();
                break;
            }
            else if (choice == "2"){
                activity = new ReflectionActivity();
                activity.Run();
                break;
            }
            else if (choice == "3"){
                activity = new ListingActivity();
                activity.Run();
                break;
            }
            else if (choice == "4"){
                activity = new GratitudeActivity();
                activity.Run();
                break;
            }
            else if (choice == "5"){
                return;
            }
            else{
                Console.WriteLine("Invalid input.");
                continue;
            }

            } while (true);
        }
    }
}
