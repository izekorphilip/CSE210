public class Entry
{
    // properties
    public string _date;
    public string _promptText;
    public string _entryText;

    // method
    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n");
    }
}