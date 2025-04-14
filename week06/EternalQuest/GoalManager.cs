using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoal();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Have a great day!");
                    return;
            }
        }

    }

    // public void ListGoalNames() 
    // {
    //     foreach (var goal in _goals)
    //     {
    //         Console.WriteLine($"- {goal.GetStringRepresentation()}");
    //     }
    // }
    public void ListGoalDetails()
    {
        int count = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }
    public void GoalType()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
    public void CreateGoal()
    {
        GoalType();

        Console.WriteLine("Which type of goal would you like to create? ");
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
        GoalType();

        Console.WriteLine("Which goal did you accomplish? ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine());
        Goal selectGoal = _goals[choice -1];
        selectGoal.RecordEvent();

        int points = int.Parse(selectGoal.GetPoints());
        _score += points;
        Console.WriteLine($"Congratulations! you have earned {selectGoal.GetPoints()} points.");

    }
    public void SaveGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();

        using(StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line= reader.ReadLine()) != null)
            {   
                string [] parts = line.Split("|");
                string type = parts[0];
                string name = parts[1];
                string description = parts [2];
                string points = parts [3];

                switch (type)
                {
                    case "SimpleGoal":
                        bool IsComplete = bool.Parse(parts[4]);
                        int simplePoints = int.Parse(points);
                        var simpleGoal = new SimpleGoal(name, description, simplePoints.ToString());
                        simpleGoal.MarkComplete(IsComplete);
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        int eternalPoints = int.Parse(points);
                        _goals.Add(new EternalGoal(name, description, eternalPoints.ToString()));
                        break;
                    case "ChecklistGoal":
                        int checklistPoints = int.Parse(points);
                        int target = int.Parse(parts[4]);
                        int? bonus = string.IsNullOrWhiteSpace(parts[5]) ? (int?)null : int.Parse(parts[5]);
                        int amountCompleted = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(name, description, checklistPoints.ToString(), target, bonus ?? 0)
                        {
                            AmountCompleted = amountCompleted
                        });
                        break;
                    
                }

            }
        }
    }

    
}