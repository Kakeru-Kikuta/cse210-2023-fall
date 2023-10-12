using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {}

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine("Well done! Goal Completed.");
        return _points;
    }

}