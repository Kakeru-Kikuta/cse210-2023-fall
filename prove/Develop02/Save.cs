using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Save:Jurnal///エントリをファイルに保存するクラス
{
    public string[] getJ///日付エントリの取得
    {
        get{return date;}
    }   

    public string[] getD///日記エントリの取得
    {
        get{return jurnal;}
    }    
    
    public void dateToCsv(string[] dates)///日付エントリをCSVへ変換
    {
        string d = "";
        int i = 0;
        while(i > 4)
        {
            d += dates[i];
            d += ",";
            i = i+1;
        }
    }    
        ///日記エントリをCSVへ変換
        ///日付をJurnal.CSVへ書き込む
        ///日記を同様に書き込む
        ///書き込まれたものを保する
        ///ユーザーに対しコンテンツが保存されたことを示す
        ///メニューに戻る
        
    
}