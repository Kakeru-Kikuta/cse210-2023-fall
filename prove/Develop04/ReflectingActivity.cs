using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;


class ReflectingActivity : Activity
{
    private string[] _prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration)
         : base(name, description,duration)
    {

    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int pIndex = rnd.Next(_prompts.Length);
        return _prompts[pIndex];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int qIndex = rnd.Next(_questions.Length);
        return _prompts[qIndex];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }
}