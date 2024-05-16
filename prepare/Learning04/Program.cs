using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");

        Assignment myAssignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(myAssignment1.GetSummary());


        MathAssignment mathAssignment2 = new MathAssignment("Philip Izekor","Fraction", "7.3", "8-9");
        Console.WriteLine(myAssignment1.GetSummary());
        Console.WriteLine(mathAssignment2.GetHomeworkList());

        WritingAssignment myAssignment3 = new WritingAssignment("Philip Izekor", "European History","The Causes of World War II");
        Console.WriteLine(myAssignment1.GetSummary());
        Console.WriteLine(myAssignment3.GetWritingInformation());

    }
}