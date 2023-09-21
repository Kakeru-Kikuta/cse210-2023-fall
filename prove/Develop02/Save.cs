using System;
using System.IO;
using System.Text;

class Save
{
    public void saveToFile()///エントリをファイルに保存するメソッド(voidは暫定処置)
    {
        ///ユーザーにファイル名の入力を求める
        Console.WriteLine("Enter the filename");
        ///ユーザーからの入力を定義
        string userFile = Console.ReadLine();
        ///ユーザーの入力を参照
        using (StreamWriter outoputFile = new StreamWriter(userFile))
        {
            outoputFile.WriteLine("");
        }
        ///指定されたファイルを特定する
        ///エントリを追加して保存する
    }
}