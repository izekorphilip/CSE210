using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");
        
         DisplayWelcome ();

         string myUserName = PromptUserName();

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
        
        
        
}