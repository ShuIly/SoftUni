using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _10._Use_Your_Chains_Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<p>(.*?)<\/p>");
            string str = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            MatchCollection matches = regex.Matches(str);

            foreach (Match match in matches)
            {
                StringBuilder sb = new StringBuilder(Regex
                    .Replace(match.Groups[1].Value, "[^a-z0-9]+", " "));

                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] >= 'a' && sb[i] <= 'm')
                    {
                        sb[i] = (char) (sb[i] + 13);
                    }
                    else if (sb[i] >= 'n' && sb[i] <= 'z')
                    {
                        sb[i] = (char) (sb[i] - 13);
                    }
                }

                result.Append(sb);
            }

            Console.WriteLine(result);
        }
    }
}
