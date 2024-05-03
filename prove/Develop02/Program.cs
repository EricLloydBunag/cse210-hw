using System;


class Program
{
    static void Main(string[] args)
    {
        string userOption;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Welcome to your journal! What do you want to do?");
            Console.WriteLine("1. Write \n2. Display Entries \n3. Save to File \n4. Load File \n5. Exit");
            userOption = Console.ReadLine();
            if (userOption == "1")
            {
                journal.AddEntry();
            }
            else if (userOption == "2")
            {
                journal.DisplayAll();
            }

            else if (userOption == "3") { 
                journal.SaveToFile();
            }

            else if (userOption == "4") { 
                journal.LoadToFile();
            }

            else { }
        } while (userOption != "5");
    }
}