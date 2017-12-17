using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^\+359( |-)2\1\d{3}\1\d{4}$");

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
