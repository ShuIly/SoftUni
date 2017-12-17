using System;
using System.Text.RegularExpressions;

namespace _07._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=\s|^|[\/\\)(])[A-Za-z][A-Za-z0-9_]{2,24}(?=\s|$|[\/\\)(])");

            string str = Console.ReadLine();

            string match1 = String.Empty;
            string match2 = String.Empty;
            
            int maxSum = 0;
            MatchCollection matches = regex.Matches(str);

            for (int i = 1; i < matches.Count; i++)
            {
                int currSum = matches[i].Value.Length + matches[i - 1].Value.Length;
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    match1 = matches[i - 1].Value;
                    match2 = matches[i].Value;
                }
            }

            Console.WriteLine(match1 + Environment.NewLine + match2);
        }
    }
}
