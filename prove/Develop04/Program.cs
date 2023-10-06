using System;
using System.ComponentModel;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int _menuEnter = -1;
        while (_menuEnter != 4)
        {
            Console.WriteLine
            (
                "Menu options:\r\n   1. Start breathing activity\r\n    2. Start reflecting activity\r\n    3. Start listing activity\r\n   4. Quit"
            );
            Console.WriteLine("Select a choice from the menu in number.");
            string enterNum = Console.ReadLine();
            _menuEnter = int.Parse(enterNum);

            if(_menuEnter == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if(_menuEnter == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if(_menuEnter == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

        }
        
    }
}