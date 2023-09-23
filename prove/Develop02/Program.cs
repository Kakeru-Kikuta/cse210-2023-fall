using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

abstract class Jurnal///日記のエントリーの置き場所
{
    protected string[] jurnal = {"","","","","",""};
    protected int arrayCount = 0;
    
    protected string[] date = {"","","","","",""};

    public abstract string[] GatD///日付エントリの取得
    {
        get;
    }   

    public abstract string[] GetJ///日記エントリの取得
    {
        get;
    }  

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
                Program program = new Program();
                program.callGetter();
            }

            ///Road jurnal
            else if(_userMenuEnter == 4)
            {
                Road road = new Road();
                road.roadJurnalFormFile();
            }

        }
       
    }

    public void callGetter()
    {
        var save = new Save();
        
        save.dateToCsv(save.GatD);
        string d = save.dateToCsv(save.GatD);

        save.jurnalToCsv(save.GetJ);
        string j = save.jurnalToCsv(save.GetJ);

        save.savseToCSV(d,j);

    }

    
}

