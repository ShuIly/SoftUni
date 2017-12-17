using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08._Extract_Hyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
			string pattern = "<a\\s+[^>]*?href\\s*=\\s*(?:([\"\'])(?<href1>.+?)\\1|(?<href2>.+?)(?:\\s+.+?=|>))";
			var sb = new StringBuilder();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "END")
				{
					break;
				}

				sb.Append(input + Environment.NewLine);
			}

			MatchCollection matches = Regex.Matches(sb.ToString(), pattern);
			foreach (Match match in matches)
			{
				string hrefMatch = match.Groups["href1"].Value;
				if (String.IsNullOrEmpty(hrefMatch))
				{
					hrefMatch = match.Groups["href2"].Value;
				}

				Console.WriteLine(hrefMatch);
			}
        }
    }
}
