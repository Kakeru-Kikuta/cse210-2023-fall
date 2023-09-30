using System;
using System.Globalization;

public class Word///単語ごとに配列化したデータの要素が置き換えられているか否かの判断を処理する
{
    private bool isHidden = false;

    public string spTexts {get;}///テキストを配列化したものを取得

    public void Hide()///単語を隠すメソッド
    {
        isHidden = true;
        Scripture scripture =new Scripture();
        scripture.splitText();
    }

    public void Show()///単語が隠されていないことを示すメソッド
    {
        isHidden = false;
    }

    public bool IsHidden()///上二つのメソッドをもとに非表示か否かをブール値で返すメソッド
    {
        return isHidden;
    }

}