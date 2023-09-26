using System;
using System.Security.Cryptography.X509Certificates;

class Reference///book (string), chapter (int), verse (int)の変数を保存する。
{
    private string book;
    private int chapter;
    private int verse;
    /// private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        Reference reference = new Reference();
        reference.book = "Alma";
        reference.chapter = 46;
        reference.verse = 12;
        Console.WriteLine($"{book} {chapter}: {verse}");

    }


    private string GetDisplayText()
    {
        string text = "";
        return text;
    }
}