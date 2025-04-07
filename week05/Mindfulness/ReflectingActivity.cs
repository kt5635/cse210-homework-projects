using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    } 
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Please consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, please press 'Enter' to continue.");
        Console.ReadLine();

        Console.WriteLine("Please ponder on the following questions as they relate you your experience");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(3);
        DisplayQuestions();
        DisplayEndingMessage();  
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        Random random = new Random();
        string question;
        do{
            question = _questions[random.Next(_questions.Count)];
        } while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Thread.Sleep(3000);
    }
    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write(question);
            ShowSpinner(8);
            Console.WriteLine();

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }
        
    }
}