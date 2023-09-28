using System;
using System.Diagnostics.Contracts;

public class Scripture///表示テキストを文字列として取得しランダムな単語を非表示にする（＿に置き換える）
{
    private string reference;
    private string text = "And it came to pass that he rent his coat and he took a piece thereof, and wrote upon it In memory of our God, our religion, and freedom, and our peace, our wives, and our children and he fastened it upon the end of a pole.";
    
    public void splitText()
    {
        string[] spTexts = text.Split("");
        int len = spTexts.Length;
    }

    public string spTexts {get;}///表示テキストを文字列にしたものを取得する 

    public void HideRandomWords()///単語を_に置き換える
    {
        Console.Clear();
        string nonHideText = spTexts;
        ///Random randHide = new Random();
        string hideText = nonHideText.Replace("","_");

    }
}