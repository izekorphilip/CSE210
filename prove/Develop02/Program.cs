using System;
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGen = new PromptGenerator();
        promptGen._prompts = ["Who was the most interesting person I interacted with today?", 
                              "What was the best part of my day?",
                              "How did I see the hand of the Lord in my life today?",
                              "What was the strongest emotion I felt today?",
                              "If I had one thing I could do over today, what would it be?"];
        Journal myJournal = new Journal();

        int choose = 0;
        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            try
            {
                choose = int.Parse(Console.ReadLine());
                // Console.WriteLine(choose);
                Console.WriteLine();  // add space;
                if (choose == 1)
                {
                    // Console.WriteLine($"Your Choice is {choose}");
                    //step 1: select a random prompt and display it to the user
                    string prompt = promptGen.GenerateRandomPrompt();
                    Console.WriteLine(prompt);
                    //step 2: get user input
                    Console.Write("> ");
                    string userInput = Console.ReadLine();
                    //step 3: get date value
                    DateTime currentDate = DateTime.Now;
                    string date = currentDate.ToShortDateString();
                    //step 4: save all values into the entry class instance
                    Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._promptText = prompt;
                    newEntry._entryText = userInput;
                    //step 5: save the instance of the entry into the entries property of the Journal class
                    myJournal.AddEntry(newEntry);
                }
                else if (choose == 2)
                {
                    // Console.WriteLine($"Your Choice is {choose}");
                    myJournal.DisplayAllEntry();
                }
                else if (choose == 3)
                {
                    // Console.WriteLine($"Your Choice is {choose}");
                    Console.Write("Enter Filename: ");
                    string filename = Console.ReadLine();
                    myJournal.SaveToFile(filename);
                }
                else if (choose == 4)
                {
                    // Console.WriteLine($"Your Choice is {choose}");
                    Console.Write("Enter Filename: ");
                    string filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename);
                }
                else if (choose == 5)
                {
                    Console.WriteLine($"Your Choice is {choose}");
                    Console.WriteLine($"Thank you for running the journal project.\nProgram Exit Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option: Pleaase select from the options provided.");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Entry: Numbers Only\nPlease select an option from the options provided.\n");
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}