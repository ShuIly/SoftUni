using System;
using System.Text.RegularExpressions;

namespace _01._Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(Console.ReadLine());
            string str = Console.ReadLine();

            int matchCount = regex.Matches(str).Count;
            Console.WriteLine(matchCount);
        }
    }
}
