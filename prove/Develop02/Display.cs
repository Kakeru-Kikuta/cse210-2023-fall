using System;
using System.Dynamic;

class Display:Jurnal///エントリへのアクセスのためにClass Jurnal を継承
{
    public override string[] GatD
    {
        get{return date;}
    }

    public override string[] GetJ
    {
        get{return jurnal;}
    }

    public void displayEntry()
    {
        Display d = new Display();

        int i = 0;
        while(i > 4)
            {
                Console.WriteLine(d.GatD[i]);
                Console.WriteLine(d.GetJ[i]);
                i = i+1;
            }

        
    }
}