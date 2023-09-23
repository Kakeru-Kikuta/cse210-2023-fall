using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Save:Jurnal///エントリをファイルに保存するクラス
{
    public override string[] GatD
    {
        get{return date;}
    }

    public override string[] GetJ
    {
        get{return jurnal;}
    }

    public string dateToCsv(string[] dates)///日付エントリをCSVへ変換
    {
        string d = "";
        int i = 0;
        while(i > 4)
        {
            d += dates[i];
            d += ",";
            i = i+1;
        }
        return d;
    }    
    
    public string jurnalToCsv(string[] jurnals)///日記エントリをCSVへ変換
    {
        string j = "";
        int i = 0;
        while(i > 4)
        {
            j += jurnals[i];
            j += ",";
            i = i+1;
        }
        return j;
    }       
        
    public void savseToCSV(string d,string j)///日付と日記をJurnal.CSVへ書き込む
    {
        string fileName = "Jurnal.CSV";

        using (StreamWriter outputFile = new StreamWriter (fileName))
        {
            outputFile.WriteLine($"{d}{j}");
        }

        Console.WriteLine("Entry saved.");///ユーザーに対しコンテンツが保存されたことを示す
    }
    ///メニューに戻る
}