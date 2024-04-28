using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        int guess = -1;
        int guesses = 0;
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess");
            guess = int.Parse(Console.ReadLine());

            guesses = guesses+1;
            if (guess > magicNumber)
            {
                Console.WriteLine("Guess Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else
            {
                Console.WriteLine($"Your guess is correct.");
                Console.WriteLine("This magic number is:" + magicNumber);
            }  
        }
        Console.WriteLine(guesses);
    }
}