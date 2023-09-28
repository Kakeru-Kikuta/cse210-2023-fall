using System;
using System.Security.Cryptography.X509Certificates;

public class Reference///book (string), chapter (int), verse (int)の変数を保存する。
{
    private string book ="Alma";
    private int chapter = 46;
    private int verse = 12;

    public Reference(string book, int chapter, int verse)
    {
        Console.WriteLine($"{book} {chapter}: {verse}");
    }

}