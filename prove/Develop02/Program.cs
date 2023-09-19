using System;
using System.Data.Common;


class Program
{
    static void Main(string[] arge)
    {

        int _userMenuEnter = -1;
        while(_userMenuEnter < 4)
        {
            Console.WriteLine("Welcome to your journal! What do you want to do? Enter a menu number. \r\n1, Whrite new Journal. \r\n2 Show all Journal. \r\n3 Save your Journal. \r\n4 Road your Journal.");

            string userE = Console.ReadLine();
            _userMenuEnter = int.Parse(userE);

            ///Write jurnal
            if(_userMenuEnter == 1)
            {

            }

            ///Display jurnal
            else if(_userMenuEnter == 2)
            {

            }

            ///Save jurnal 
            else if(_userMenuEnter == 3)
            {

            }

            ///Road jurnal
            else if(_userMenuEnter == 4)
            {

            }

            ///End program
            else
            {

            }

        }

       
    }

    
}

