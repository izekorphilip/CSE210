using System.ComponentModel;
using System.IO;

public class Journal
{
    // properties
    public List<Entry> _entires = new List<Entry>();

    // methods
    public void AddEntry(Entry newEntry)
    {
        _entires.Add(newEntry);
    }
    public void DisplayAllEntry()
    {
        foreach (Entry singleEntry in _entires)
        {
            singleEntry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        fileName = $"{fileName}.txt";
        using (StreamWriter entryFile = new StreamWriter(fileName))
        {
            foreach (Entry singleEntry in _entires)
            {
                entryFile.WriteLine($"{singleEntry._date}*{singleEntry._promptText}*{singleEntry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        fileName = $"{fileName}.txt";
        string[] allLines = File.ReadAllLines(fileName);
        // loop through all lines and add value to entry
        foreach (string line in allLines)
        {
            string[] parts = line.Split('*');
            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            // load datas to _entry
            Entry singleEntry = new Entry();
            singleEntry._date = date;
            singleEntry._promptText = promptText;
            singleEntry._entryText = entryText;
            AddEntry(singleEntry);
        }
    }
}