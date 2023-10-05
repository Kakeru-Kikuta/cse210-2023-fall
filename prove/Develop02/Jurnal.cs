using System;

abstract class Jurnal///日記のエントリーの置き場所
{
    protected string[] jurnal = {"","","","","",""};
    protected int arrayCount = 0;
    
    protected string[] date = {"","","","","",""};

    public abstract string[] GatD///日付エントリの取得
    {
        get;
    }   

    public abstract string[] GetJ///日記エントリの取得
    {
        get;
    }  

}