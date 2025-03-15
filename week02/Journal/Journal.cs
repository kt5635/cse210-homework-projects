using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Your new journal entry has been added");

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
            string filePath = Path.Combine(Environment.CurrentDirectory, file);
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Your journal entries have been saved to {filePath}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }

    }
    public void LoadFromFile(string file)
    {
        try 
        {   
            string filePath = Path.Combine(Environment.CurrentDirectory, file);
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No saved journal file found.");
                return;
            }

            string json = File.ReadAllText(filePath);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("Journal Entries have been loaded");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}