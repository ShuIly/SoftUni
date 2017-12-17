using System;
using System.Text.RegularExpressions;

namespace _06._Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            string sentences = Console.ReadLine();

            Regex regex = new Regex($@"[^.!?]*\b{word}\b.*?[.!?]");

            MatchCollection matches = regex.Matches(sentences);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
