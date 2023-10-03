using System;

class ListingActivity : Activity
{
    private int _count;
    private string[] _prompts =  
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration, int count) 
        : base(name, description, duration)
    {
        name = "Listing Activity";
        description = 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        duration = 50;
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int pIndex = rnd.Next(_prompts.Length);
    }

    public GetListFromUser()
    {
        return 
    }
}