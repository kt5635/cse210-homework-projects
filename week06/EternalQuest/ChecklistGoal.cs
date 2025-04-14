using System;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int? _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public int AmountCompleted
    {
        get {return _amountCompleted;}
        set {_amountCompleted = value;}
    }

    public int? Bonus
    {
        get {return _bonus;}
        set { _bonus = value;}
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You have completed {_shortName} {_amountCompleted} / {_target}");
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! you have completed the target of {_target} completions and earned a bonus of {_bonus} points!");
            _points = (int.Parse(_points)+_bonus).ToString();
        }

    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{(_bonus.HasValue ? _bonus.Value.ToString() : "")}|{_amountCompleted}";
    }
    public override string GetDetailsString()
    {
        return (IsComplete() ? "[X]" : "[ ]") + $" {_shortName} ({_description}) -- Competed: {_amountCompleted}/{_target}";
    }
}