using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");

        string letter = "";
        Console.Write("What is your grade? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        if(grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if(grade < 60)
        {
            letter = "D";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if(grade >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Try better next time.");
        }
    }

  
}