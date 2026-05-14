using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    public List<Entry> _entries= new List<Entry>();

    public void ADDEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
 using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompttext}|{entry._entrytext}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
      string[] lines = System.IO.File.ReadAllLines(file);
          foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompttext = parts[1];
                    entry._entrytext = parts[2];
                    _entries.Add(entry);
                }
            }   
    }


}