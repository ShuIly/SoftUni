using System;
using System.Text.RegularExpressions;

namespace _03._Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("[^\\d]");
            string str = Console.ReadLine();

            int matchCount = regex.Matches(str).Count;
            Console.WriteLine($"Non-digits: {matchCount}");
        }
    }
}
