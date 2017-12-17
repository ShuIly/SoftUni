using System;
using System.Text.RegularExpressions;

namespace _06._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("^[a-zA-Z0-9_-]{3,16}$");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                Match match = regex.Match(input);

                Console.WriteLine(match.Success ? "valid" : "invalid");
            }

        }
    }
}