using System;
using System.Text.RegularExpressions;

namespace _02._Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("[AEIOUYaeiouy]");
            string str = Console.ReadLine();

            int matchCount = regex.Matches(str).Count;
            Console.WriteLine($"Vowels: {matchCount}");
        }
    }
}
