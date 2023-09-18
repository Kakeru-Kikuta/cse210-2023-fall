using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace Demo
{   
    public class Program
    {
        static void Main(String[] args)
        {

            Prompt prompt = new Prompt();
            prompt._prompt1 = "Who was the most interesting person I interested with todday?";
            prompt._prompt2 = "What was the best part of my day?";
            prompt._prompt3 = "How did I see the hand of the Lord in my life today?";
            prompt._prompt4 = "What was the strongest emotion I felt today?";
            prompt._prompt5 = "If I had one thing I could do over today, what would it be?";

            List<Prompt> quesutions = new List<Prompt>();
            quesutions.Add(prompt);
            

        }

    


    }

}