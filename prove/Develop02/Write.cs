using System;
using System.Reflection.Emit;

class Write:Jurnal
{
    ///Ask a random question
    private string[] prompt = {"A","B","C","D","E"};
    
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

