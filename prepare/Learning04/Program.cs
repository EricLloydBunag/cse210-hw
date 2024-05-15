using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment= new MathAssignment("Leucis Faringray", "C#", "6.4", "5-7");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());

        WritingAssignment writingAssignment= new WritingAssignment("Arwaine Lancaster", "Physical Fitness", "On Good Health");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}