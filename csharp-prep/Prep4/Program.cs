using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Philip World!");

        List<int> numbers = new List<int>();
        
        int singleNumber = -1;

        while (singleNumber != 0)
        {
            Console.Write("Enter a list of number. Typing 0 will make it stop: ");
            singleNumber = int.Parse(Console.ReadLine());
            
            if(singleNumber != 0)
            {
               numbers.Add(singleNumber);
            }
            else
            {
                int sum = numbers.Sum();
                Console.WriteLine("The sum of the number in the list is: " + sum);

               float averageNumber = ((float)sum) / numbers.Count;
               Console.WriteLine("The average is: " + averageNumber);

               int largest = numbers.Max();
               Console.WriteLine("The largest number is: " + largest);
                numbers.Sort();
                Console.WriteLine("The sorted list is: ");
                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }   
            }
        }
    }
}