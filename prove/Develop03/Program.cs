using System;
using System.Dynamic;

public class Program///プログラムはユーザがエンターを押し続けてすべての単語を非表示にした場合と”quit”を直接入力した場合に終了する
{
    public int len {get;} ///配列の要素数情報を取得 <summary>
    public string userEntry = "";
    static void Main(string[] arge)
    {
        Console.WriteLine("Hit Enter key. If you want to quit entr quit on your console.");
        
        while(Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Scripture scripture = new Scripture();
            scripture.splitText();
            string userEntry = Console.ReadLine();

            if (userEntry == "quit")
            {
                break;
            }
        }
        
        
    }
}