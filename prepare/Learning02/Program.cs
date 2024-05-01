using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2019";
        job1._endYear = "2021";
        

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = "2022";
        job2._endYear = "2023";
        

        Resume newResume = new Resume();
        newResume._name = "Philip";
        newResume._resume.Add(job1);
        newResume._resume.Add(job2);
        
        newResume.DisplayResume();
    }
}
