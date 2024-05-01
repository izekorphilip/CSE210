using System;
public class Resume
{
    public string _name;
    public List<Job> _resume = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("jobs:");

     foreach (Job job in _resume)
        {
            // This calls the Display method on each job
            job.DisplayResume();
        }
    }
}





