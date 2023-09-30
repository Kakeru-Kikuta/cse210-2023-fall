using System;
using System.Diagnostics.Contracts;

public class Scripture///表示テキストを文字列として取得しランダムな単語を非表示にする（＿に置き換える）
{
    private string reference;
    private string text = "And it came to pass that he rent his coat and he took a piece thereof, and wrote upon it In memory of our God, our religion, and freedom, and our peace, our wives, and our children and he fastened it upon the end of a pole.";
    
    public void splitText()///テキストを単語で分割し配列に格納
    {
        string[] spTexts = text.Split(",");
        int len = spTexts.Length;///配列の要素数を定義しておく
    }

    public string spTexts {get;}///テキストを配列化したものを取得
    
    public void HideRandomWords()///単語を_に置き換える
    {
        Console.Clear();
        string nonHideText = spTexts;
        Random randHide = new Random();
        randHide.Next(0,50);

        string hideText = nonHideText.Replace(" ","_");

        Console.WriteLine(reference,$"{hideText}");

    }

}