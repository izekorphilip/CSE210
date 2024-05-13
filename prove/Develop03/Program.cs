using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object
            Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            // Hide words until all words are hidden or user types quit
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("Press enter to hide more words, or type 'quit' to exit:");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    break;

                scripture.HideRandomWords(2); // Hide 2 random words
            }
        }
    }
    
