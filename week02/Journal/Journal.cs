using System;
using System.Collections.Generic;
using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("You new journal entry has been added");

    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No Entries found.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Your Journal Entries");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        try 
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
            Console.Write("Your journal entry has been saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }

    }
    public void LoadFromFile( string file)
    {
        try 
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("No saved journal file found.");
                return;
            }

            string[] lines = File.ReadAllLines(file);
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " || "}, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string entryText = parts[2];
                    _entries.Add(new Entry());
                }
            }
            Console.WriteLine("Journal entries have been loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}