using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {}

    public override int RecordEvent()
    {
        Console.WriteLine("Well done!");
        return _points;
    }

    public override string GetDetailsString()
    {
       return $"[ ] {_shortName}: ({_description})";
    }
}