using System;
using System.Reflection.Emit;

class Write:Jurnal
{
    public override string[] GatD
    {
        get{return date;}
    }

    public override string[] GetJ
    {
        get{return jurnal;}
    }
    
    ///Ask a random question
    private string[] prompt = {"Best moment for today; ","The thing that you want to improve; ","Best food for today","Today's highest driving speed; ","An Attrractive object; "};
    
    public string output_prompt()
    {
        Random _randPrompt = new System.Random();
        return prompt[_randPrompt.Next(0,4)];
        
    }
    
    public void jurnalWrite(string jData)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        date[arrayCount] = dateText;
        jurnal[arrayCount] = jData;
        arrayCount = arrayCount +1;
    }
}

