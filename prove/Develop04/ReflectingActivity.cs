using System;
using System.ComponentModel;
using System.Numerics;

class ReflectingActivity : Activity
{
    List<string>_prompts = new List<string>();
    List<string>_questions =new List<string>();

    public ReflectingActivity()
    {
        
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return ///ランダムなプロンプトを1つ返す
    }

    public string GetRandomQuestion()
    {
        return ///ランダムなクエスチョンを１つ返す
    }

    public void DisplayPrompt()
    {
        ///GetRandomPromptで返されたものをディスプレイ
    }

    public void DisplayQuestions()
    {
        ///GetRandomQuestionで返されたものをディスプレイ
    }
}