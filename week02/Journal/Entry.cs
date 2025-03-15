using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;

public class Entry {
    public DateTime _date = DateTime.Today;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();
    }
    public Entry(DateTime date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date:yyy-MM-dd}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }

    public override string ToString()
    {
        return $"{_date:yyyy-MM-dd} || {_promptText} || {_entryText}";
    }
}