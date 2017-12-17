using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string regex = @"(.)\1*";

            string result = String.Empty;
            MatchCollection matches = Regex.Matches(str, regex);

            foreach (Match match in matches)
            {
                result += match.Groups[1];
            }

            Console.WriteLine(result);
        }
    }
}
