using System;

public class Entry {
    public DateTime _date = DateTime.Today;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();
    }

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}