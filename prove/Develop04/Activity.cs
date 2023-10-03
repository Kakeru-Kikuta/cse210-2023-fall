using System;
using System.Runtime.InteropServices;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(string name)
    {
        Console.WriteLine($"Welcome to {name}.");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good work!");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int second)
    {

    }
}