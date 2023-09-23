using System;
using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;
using System.Text;
class Road
{
    
    public void roadJurnalFormFile()///ファイルに保存された日記をロードするメソッド
    {
        string oF = "Jurnal.CSV";
        StreamReader reader = new StreamReader(@oF);///ファイルを開く

        List<string[]> entryLists = new List<string[]>();
        int i = 0;

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (i == 0)
            {
                string[] cols = line.Split(",");
                i +=1;
                continue;
            }

            string[] userJurnal =line.Split(",");
            entryLists.Add(userJurnal);
        }

        Console.WriteLine($"{entryLists}");///表示する
        
    }
}       ///保存されているデータはコンマで区切られているためCSVのルールによりデータは
        ///右に伸びていると推測される。行数は2行で上下のいずれかに日記データと日付データが
        ///割り当てられておりデータは保存したエントリの数だけの列数がある。
        