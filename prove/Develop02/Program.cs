using System;
using System.Data.Common;

abstract class Jurnal///日記のエントリーの置き場所
{
    protected string[] jurnal = {"","","","","",""};
    protected int arrayCount = 0;
    
    protected string[] date = {"","","","","",""};

}


class Program
{
    static void Main(string[] arge)
    {
        Write nikki  = new Write();
        int _userMenuEnter = -1;
        while(_userMenuEnter == 5)
        {
            Console.WriteLine("Welcome to your journal! What do you want to do? Enter a menu number. \r\n1, Whrite new Journal. \r\n2 Show all Journal. \r\n3 Save your Journal. \r\n4 Road your Journal.");

            string userE = Console.ReadLine();
            _userMenuEnter = int.Parse(userE);

            ///Write jurnal
            if(_userMenuEnter == 1)
            {
                Console.WriteLine (nikki.output_prompt());
                nikki.jurnalWrite(Console.ReadLine());
            }

            ///Display jurnal
            else if(_userMenuEnter == 2)
            {
                Display display = new Display();
                display.displayEntry();
            }

            ///Save jurnal 
            else if(_userMenuEnter == 3)
            {

            }

            ///Road jurnal
            else if(_userMenuEnter == 4)
            {

            }

        }


       
    }

    
}

