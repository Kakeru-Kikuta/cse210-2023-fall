using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace entryCode
{
    public class Entry
    {
        static void Main(string[] args)
            {
                Questions p1 = new Questions();
                p1._prompt1 = "Who was the most interesting person I interested with todday?";
                p1._prompt2 = "What was the best part of my day?";
                p1._prompt3 = "How did I see the hand of the Lord in my life today?";
                p1._prompt4 = "What was the strongest emotion I felt today?";
                p1._prompt5 = "If I had one thing I could do over today, what would it be?";

                List<Questions> question = new List<Questions>();
                question.Add(p1);
            }
        static void Main(string[] args)
            {
                Console.Write("Current Date and Time is: ");
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
                Console.ReadLine();

            }

        string fileName = "journal_history.txt";
        string journal_entry = outputFile.ReadLine();
        public static async Task journalEmtry()
        {
            string entry = WriteLine($"{journal_entry}");
            using StreamWriter file = new("WirteLine2.txt", append:true);
            await file.WriteLineAsync("Fourth line");
        }
    }
}
