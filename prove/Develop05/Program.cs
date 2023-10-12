using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {   
        GoalManager manager = new GoalManager();
        string _menuInput = "";
        while (_menuInput != "6")
        {
            Console.WriteLine($"You have {manager.GetScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("\n Press '6' to quit.");
            Console.WriteLine("Select a choice form the menu: ");
            _menuInput = Console.ReadLine();
            switch(_menuInput)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    manager.SaveGoals();
                    break;
                case "4":
                    manager.LoadGoals();
                    break;
                case "5":
                    manager.RecordEvent();
                    break;
            }
        }
    }
}