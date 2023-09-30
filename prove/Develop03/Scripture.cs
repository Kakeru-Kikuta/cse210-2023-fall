using System;
using System.Diagnostics.Contracts;
using System.Xml.Schema;

public class Scripture///表示テキストを文字列として取得しランダムな単語を非表示にする（＿に置き換える）
{
    private string text = "And it came to pass that he rent his coat and he took a piece thereof and wrote upon it In memory of our God our religion and freedom and our peace our wives and our children and he fastened it upon the end of a pole.";
    
    public void splitText()///テキストを単語で分割し配列に格納
    {
        string[] spTexts = text.Split(",");
        foreach (string t in spTexts)
        {
            string hideText = t.Replace(" ","_");
            string[] hT = new string[]{$"{hideText}"};
            Random randHide = new Random();
            int randCount = randHide.Next(0,46);
            Console.WriteLine(hT[randCount]);
        }
    }
}