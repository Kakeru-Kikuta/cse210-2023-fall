using System;

class ListingActivity : Activity
{
    private string[] _prompts =  
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        // List items based on the following prompt
        // display prompt
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < end)
        {
            // get user input
            // count++
        }
        
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int pIndex = rnd.Next(_prompts.Length);
    }
}