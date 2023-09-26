using System;
using System.Globalization;

class Word///単語自体のテキスト（文字列）とその単語が表示されるか非表示かを示す変数（ブール値）を格納する
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        Word word = new Word();
        word.text = "And it came to pass that he rent his coat; and he took a piece thereof, and wrote upon it In memory of our God, our religion, and freedom, and our peace, our wives, and our children and he fastened it upon the end of a pole.";
    }

    public void Hide()///単語を隠すメソッド
    {
        
    }

    public void Show()///単語が隠されていないことを示すメソッド
    {

    }

    public bool IsHidden()///上二つのメソッドをもとに非表示か否かをブール値で返すメソッド
    {
        
    }

    public string GetDisplayText()///Scriptureクラスで表示テキストを文字列として取得したものをゲットする
    {
        string text = "";
        return text;
    }
}