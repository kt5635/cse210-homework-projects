using System;
using System.IO;

public class GoalManager
{
    private List<string> _goals = new List<string>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine($"You have {DisplayPlayerInfo()} points.");
        Console.WriteLine();

        while (true)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

        Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            CreateGoal();
        }

        else if (choice == 2)
        {
            
        }

        else if (choice == 3)
        {
            SaveGoal();
        }

        else if (choice == 4)
        {
            LoadGoals();
        }

        else if (choice == 5)
        {
            RecordEvent();
        }

        else if (choice == 5)
        {
            Console.Write("\nHave a great Day!");
            break;
        }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames() 
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.WriteLine("Whck type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with the goal? ");
        string points = Console.ReadLine();

        if (goalChoice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalChoice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        if (goalChoice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
    public void RecordEvent()
    {

    }
    public void SaveGoal()
    {

    }
    public void LoadGoals()
    {

    }

    
}