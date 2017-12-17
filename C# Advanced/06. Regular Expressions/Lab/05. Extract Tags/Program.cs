using System;
using System.Text.RegularExpressions;

namespace _05._Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("<.+?>");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
    }
}
