using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _09._Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=&|^|\?)(?<key>[^\?]+?)=(?<values>.+?)(?=&|$)");


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                var queriesDict = new Dictionary<string, List<string>>();

                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {

                    string[] keyParts = match.Groups["key"].Value
                        .Split(new[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries);

                    string key = string.Join(" ", keyParts).Trim();

                    if (!queriesDict.ContainsKey(key))
                    {
                        queriesDict.Add(key, new List<string>());
                    }

                    string[] values = match.Groups["values"].Value
                        .Split(new[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries);

                    queriesDict[key].Add(string.Join(" ", values).Trim());

                }

                string result = String.Empty;
                foreach (var queryKey in queriesDict.Keys)
                {
                    result += $"{queryKey}=[{string.Join(", ", queriesDict[queryKey])}]";
                }

                Console.WriteLine(result);
            }
        }
    }
}
