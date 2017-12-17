using System;
using System.Text.RegularExpressions;

namespace _07._Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("^(0?[0-9]|1[0-2])(:[0-5]?[0-9]){2}\\s?(A|P)M$");

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
