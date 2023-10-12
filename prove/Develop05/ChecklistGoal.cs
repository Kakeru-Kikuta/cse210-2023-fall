using System;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Numerics;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string shortName, string description, int points, bool isComplete, int timesCompleted, int target, int bonus) : base(shortName, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;
        if(_amountCompleted == _target)
        {
            _isComplete = true;
            Console.WriteLine("Well Done! Goal Completed");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine("Well Done.");
            return _points;
        }
    }

    public override string GetDetailsString()
    {
        return $"[{GetCompleteChar()}] {_shortName}: ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetFileString()
    {
        return $"Checklist|{_shortName}|{_description}|{_points}|{_isComplete}|{_amountCompleted}|{_target}|{_bonus}";
    }

}