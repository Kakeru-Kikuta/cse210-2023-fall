using System;
using System.ComponentModel;
using System.Globalization;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();

    public bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetDetailsString()
    {
        return $"[{GetCompleteChar()}] {_shortName}: ({_description})";
    }

    protected char GetCompleteChar()
    {
        if(_isComplete)
        {
            return 'X';
        }
        else
        {
            return ' ';
        }
    }
}