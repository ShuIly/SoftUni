using System;
using System.Text.RegularExpressions;

namespace _05._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=\s|^)([A-Za-z0-9]+[\._-])*[A-Za-z0-9]+@([A-Za-z0-9]+[\._-])+[A-Za-z0-9]+(?=\s|$|\.|,)");

            string str = Console.ReadLine();

            MatchCollection matches = regex.Matches(str);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
