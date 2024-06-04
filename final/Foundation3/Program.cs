using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Cityville", "California", "USA");
        LectureEvent lecture = new LectureEvent("Tech Talk", "A talk on the latest in technology.", new DateTime(2024, 6, 10), new DateTime(2024, 6, 10, 18, 0, 0), lectureAddress, "Jane Doe", 100);

        Address receptionAddress = new Address("456 Elm St", "Townsville", "Florida", "USA");
        ReceptionEvent reception = new ReceptionEvent("Networking Event", "An evening of networking.", new DateTime(2024, 7, 15), new DateTime(2024, 7, 15, 19, 0, 0), receptionAddress, "rsvp@example.com");

        Address outdoorAddress = new Address("789 Oak St", "Villageville", "Ohio", "USA");
        OutdoorEvent outdoor = new OutdoorEvent("Summer Picnic", "A fun day in the sun.", new DateTime(2024, 8, 20), new DateTime(2024, 8, 20, 12, 0, 0), outdoorAddress, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();
    }
}