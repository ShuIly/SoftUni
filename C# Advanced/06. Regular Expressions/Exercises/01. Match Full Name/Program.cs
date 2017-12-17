using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("^[A-Z][a-z]+ [A-Z][a-z]+$");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
