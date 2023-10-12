using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
    }

    public int GetScore()
    {
        return _score;
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Which goal would you like to create:");
        Console.WriteLine("1) Simple Goal");
        Console.WriteLine("2) Eternal Goal");
        Console.WriteLine("3) Checklist Goal");
        Console.WriteLine("\n Press 'Enter' to return to the menu");

        string _userInput = Console.ReadLine();
        switch(_userInput)
        {
            case "1":
                Console.Write("Enter the goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal simplegoal = new(name, description, points);
                _goals.Add(simplegoal);
                break;
            case "2":
                Console.Write("Enter the goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter the goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter goal points: ");
                points = int.Parse(Console.ReadLine());
                EternalGoal eternalgoal = new(name, description, points);
                _goals.Add(eternalgoal);
                break;
            case "3":
                Console.Write("Enter the goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter the goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter goal points: ");
                points = int.Parse(Console.ReadLine());
                Console.Write("Enter target completion amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus amount: ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistgoal = new(name, description, points, target, bonus);
                _goals.Add(checklistgoal);
                break;
        }
    }

    public void RecordEvent()
    {
        // Create temporary goals list (uncompletedGoals)
        List<int> indexs = new();
        // INDEX: 0  1  2  3 ...
        //        5  7  8  12... 
        // create counter variable to represent the printed index (int counter = 1)
        int counter = 1;
        int index = 0;
        // Loop through the main goals list
        foreach (Goal goal in _goals)
        {
            if(!goal.IsComplete())
            {
               indexs.Add(index);
               Console.WriteLine($"{counter}) {goal.GetDetailsString()}");
               counter++;
            }
            index++;
        }
        int userInput = int.Parse(Console.ReadLine());
        _score += _goals[indexs[userInput]].RecordEvent();

    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file?: ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileString());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch(type)
            {
                case "Eternal":
                    EternalGoal eGoal = new(name, description, points);
                    _goals.Add(eGoal);
                    break;
                case "Simple":
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal sGoal = new(name, description, points, isComplete);
                    _goals.Add(sGoal);
                    break;
                case "Checklist":
                    isComplete = bool.Parse(parts[4]);
                    int timesCompleted = int.Parse(parts[5]);
                    int target = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);
                    ChecklistGoal cGoal = new(name, description, points, isComplete, timesCompleted, target, bonus);
                    _goals.Add(cGoal);
                    break;
                default:
                    Console.WriteLine("Unable to load goal.");
                    break;
            }
        }
    }
}