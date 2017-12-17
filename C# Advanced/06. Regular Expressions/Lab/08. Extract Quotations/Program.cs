using System;
using System.Text.RegularExpressions;

namespace _08._Extract_Quotations
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("([\"\'])(.+?)\\1");

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
