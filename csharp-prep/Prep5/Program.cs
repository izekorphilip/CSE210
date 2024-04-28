using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");

        DisplayWelcome();

        string myUserName = PromptUserName();

        int number = PromptUserNumber();

        int squaredNumb = SquareNumber(number);
        

        DisplayResult(myUserName, squaredNumb);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your userName? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number? ");
        int favouriteNumber = int.Parse(Console.ReadLine());
        return favouriteNumber;
    }

    static int SquareNumber(int squaredNum)
    {
        int squaredNumber = squaredNum * squaredNum;
        return squaredNumber;
    }

    static void  DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }

}