using System;

// Program class to demonstrate the functionality
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Foundation3, Philip World!");
        // Create address instances
        var address1 = new Address("45 seaview", "Ikeja", "Lagos", "Nigeria");
        var address2 = new Address("567 Enablele", "Benin city", "Edo state", "Nigeria");
        var address3 = new Address("789 Jumieral", "Dubai", "FICT", "UAE");

        // Create event instances
        var lecture = new Lecture("C# Advanced Topics", "An advanced lecture on C#", "2024-06-01", "10:00 AM", address1, "Dr. John Smith", 100);
        var reception = new Reception("Company Gala", "Annual company gala", "2024-06-15", "7:00 PM", address2, "rsvp@company.com");
        var outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun outdoor picnic", "2024-07-04", "12:00 PM", address3, "Sunny with a chance of showers");

        // Store events in a list
        var events = new List<Event> { lecture, reception, outdoorGathering };

        // Display information for each event
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}