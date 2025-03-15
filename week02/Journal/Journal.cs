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

            var entriesToSave = new List<object>();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                var existingEntries = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(existingJson);

                if (existingEntries != null)
                {
                    entriesToSave.AddRange(existingEntries);
                }
            }

            foreach (var entry in _entries)
            {
                var entryData = new{

                    Date = entry._date.ToString("yyyy-MM-dd"),
                    Prompt = entry._promptText,
                    EntryText = entry._entryText
                };

                bool isDuplicate = entriesToSave.Any(existingEntry =>
                {

                    var existingEntryDict = existingEntry as Dictionary<string, string>;

                    return existingEntryDict != null &&
                        existingEntryDict.ContainsKey("Date") && existingEntryDict["Date"] == entryData.Date &&
                        existingEntryDict.ContainsKey("EntryText") && existingEntryDict["EntryText"] == entryData.EntryText;
                });

                if (!isDuplicate)
                {
                    entriesToSave.Add(entryData);
                }
            }

            string json = JsonSerializer.Serialize(entriesToSave, new JsonSerializerOptions { WriteIndented = true });

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(json);
            }
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

            var entries = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(json);

            _entries.Clear();

            foreach (var entry in entries)
            {
                var newEntry = new Entry
                {
                    _date = entry.ContainsKey("Date") && DateTime.TryParse(entry["Date"], out DateTime parsedDate) 
                        ? parsedDate 
                        : DateTime.Today,
                    _promptText = entry.ContainsKey("Prompt") ? entry["Prompt"] : "No Prompt",
                    _entryText = entry.ContainsKey("EntryText") ? entry["EntryText"] : ""
                };
                _entries.Add(newEntry);
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}