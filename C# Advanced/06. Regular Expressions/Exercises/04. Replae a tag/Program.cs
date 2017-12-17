using System;
using System.Text.RegularExpressions;

namespace _04._Replae_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "end")
                {
                    break;
                }

                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, replace);

                Console.WriteLine(replaced);
            }
        }
    }
}
