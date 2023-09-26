using System;

class Scripture///表示テキストを文字列として取得しランダムな単語を非表示にする（＿に置き換える）
{
    private string reference;
    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        var texts = text;///テキストを半角スペースで区切る
        var spTexts = texts.Split(" ");
        foreach (string s in spTexts)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(spTexts.Length);
    }

    public void HideRandomWords()///ランダムな単語を_に置き換える
    {
        Console.WriteLine($"{}");
        Console.Clear();
        Console.WriteLine("_");
    }

    public string GetDisplayText()///表示テキストを文字列にしたものを取得する
    {
        string text = "";
        return text;
    }

    public bool IsComoletlyHidden()///すべての単語が隠されたかどうかを検知する
    {

    }
}