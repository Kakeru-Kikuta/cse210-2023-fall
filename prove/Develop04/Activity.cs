using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> spinner = new List<string>()
    {
        "-", "\\", "|", "/"
    };

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Good work! You have completed {_duration} seconds.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        while(seconds>0)
        {
            foreach(string i in spinner)
            {
                Console.Write(i);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            seconds--;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}