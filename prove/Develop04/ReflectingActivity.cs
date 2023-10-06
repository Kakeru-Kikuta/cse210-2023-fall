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

    private List<int> usedIndexes = new();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description =
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
 
    }

    public void Run()
    {
        DisplayStartingMessage();
        // Consider the following prompt
        // display prompt
        // reflect onthe following questions relating to the prompt
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < end)
        {
            // display the question
            // show countdown(10)
        }
        
        DisplayEndingMessage();

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
        int qIndex;
        do
        {
            qIndex = rnd.Next(_questions.Length);
        } while(usedIndexes.Contains(qIndex));

        usedIndexes.Add(qIndex);
        if (usedIndexes.Count == _questions.Length)
            usedIndexes.Clear();
            
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