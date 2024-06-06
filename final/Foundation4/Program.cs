using System;

// Program class to demonstrate the functionality
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Foundation3, Philip World!");
        // Create activity instances
        var running = new Running(new DateTime(2024, 6, 3), 30, 4.8); // 4.8 km
        var cycling = new Cycling(new DateTime(2024, 6, 3), 45, 20.0); // 20 kph
        var swimming = new Swimming(new DateTime(2024, 6, 3), 60, 40); // 40 laps

        // Store activities in a list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}