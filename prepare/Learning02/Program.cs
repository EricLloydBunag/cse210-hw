using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "XYZ Corp";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "ABC Inc.";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume resume1 = new Resume();
        resume1._name = "Eric Bunag";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}