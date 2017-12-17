using System;
using System.Text.RegularExpressions;

namespace _11._Semantic_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string semanticTags = "main|header|nav|article|section|aside|footer";

            Regex opTagRegex = new Regex($@"(?<=^)(\s*)<\s*div(\s+(?:.*?\s+)?)(?:id|class)\s*=\s*([""'])({semanticTags})\3(.*?)>(?=$)");
            Regex clTagRegex = new Regex($@"(?<=^)(\s*)<\/\s*div\s*>\s*<!--\s*({semanticTags})\s*-->");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                Match match = opTagRegex.Match(input);
                if (match.Success)
                {
                    string semTag = match.Groups[4].Value;
                    string beftag = match.Groups[2].Value;
                    string aftag = match.Groups[5].Value;

                    string indent = match.Groups[1].Value;

                    string result = $"{semTag} {beftag} {aftag}".Trim();
                    result = Regex.Replace($"<{result}>", @"\s+", " ");

                    Console.WriteLine($"{indent}{result}");
                }
                else
                {
                    match = clTagRegex.Match(input);

                    if (match.Success)
                    {
                        string semTag = match.Groups[2].Value.Trim();
                        string indent = match.Groups[1].Value;

                        Console.WriteLine($"{indent}</{semTag}>");
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }
                }
            }
        }
    }
}
