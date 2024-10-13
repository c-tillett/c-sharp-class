using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void NewEntry()//option 1
    {
        Entry currentEntry = new Entry();
        currentEntry.GetDate();
        currentEntry.GetPrompt();
        currentEntry.GetResponse();
        _entries.Add(currentEntry);
    }

    public void PrintEntries()//option 2
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._entryDate}\nPrompt: {entry._prompt}\nResponse:\n{entry._entryInput}\n");
        }
    }

    public void LoadFile(string file)//option 3
    {
        if (file == "journal.txt")
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] sections = line.Split(",");
                string entryDate = sections[0];
                string entryPrompt = sections[1];
                string entryResponse = sections[2];
                Console.WriteLine($"Date: {entryDate}\nPrompt: {entryPrompt}\nResponse:\n{entryResponse}");
            }
        }
        else
        {
            Console.WriteLine("That file is not available, try 'journal.txt'");
        }
    }

    public void SaveFile(string file)//option 4
    {
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            if (file == "journal.txt")
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._entryDate}, {entry._prompt}, {entry._entryInput}");
                }
            }
            else
            {
                Console.WriteLine("That file isn't available, please try 'journal.txt");
            }
        }
    }

}