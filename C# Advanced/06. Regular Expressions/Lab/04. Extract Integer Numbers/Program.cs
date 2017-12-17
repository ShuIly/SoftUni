using System;
using System.Text.RegularExpressions;

namespace _04._Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("\\d+");
            string str = Console.ReadLine();

            MatchCollection matches = regex.Matches(str);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
