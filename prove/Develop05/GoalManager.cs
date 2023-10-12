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

    public void LsitGoalDetails()
    {
        //Loop through the list
        //      call the GetDetailsString()
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
        List<string>_uncompletedGoals = new List<string>();
        // create counter variable to represent the printed index (int counter = 1)
        int counter = 1;
        // Loop through the main goals list
        for (string i in Goal)
        {}
        //      check if the goal is completed
        //             add the goal to the temporary list (represent the uncompleted goals)
        //             print the goal with the counter ( "1) Goal Name"   ) 
        //  get user choice
        //  _score += uncompletedGoals[choice - 1].RecordEvent()

    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file?: ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This will be the first line in the file.");
            
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }


}