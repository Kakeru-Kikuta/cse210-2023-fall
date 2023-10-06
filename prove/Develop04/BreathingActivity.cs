using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = 
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < end)
        {
            Console.Write("\n\nBreath in...");
            ShowCountDown(5);
            Console.Write("\n\nBreath out...");
            ShowCountDown(5);
        }
        
        DisplayEndingMessage();
    }
}