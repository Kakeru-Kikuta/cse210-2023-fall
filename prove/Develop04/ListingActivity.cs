using System;

class ListingActivity : Activity
{
    int _count;
    private string[] _prompts =  
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration, int count) 
        : base(name, description,duration)
    {
        _count = count;

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