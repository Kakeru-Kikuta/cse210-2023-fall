using System;
using System.Dynamic;

class Display:Jurnal///エントリへのアクセスのためにClass Jurnal を継承
{
    public string[] getJurnal ///エントリを表示するメソッドを定義（voidは暫定的な処置）
    {
        ///class Jurnalから日付データを取り出す
        get{return jurnal;}
        
    }

    public string[] getDate
    {
        get{return date;}
    }

    public void displayEntry()
    {
        Display d = new Display();

        int i = 0;
        while(i > 4)
            {
                Console.WriteLine(d.getDate[i]);
                Console.WriteLine(d.getJurnal[i]);
                i = i+1;
            }

        
    }
}