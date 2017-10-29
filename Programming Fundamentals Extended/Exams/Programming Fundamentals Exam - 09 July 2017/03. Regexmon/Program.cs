using System;
using System.Text.RegularExpressions;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
			string str = Console.ReadLine();

	        string digimonRegex = "[^A-Za-z-]+";
	        string bojomonRegex = "[A-Za-z]+-[A-Za-z]+";

	        bool digimonTurn = true;
	        while (true)
	        {
		        Match match;
		        if (digimonTurn)
		        {
			        match = Regex.Match(str, digimonRegex);
			        digimonTurn = false;
		        }
		        else
		        {
			        match = Regex.Match(str, bojomonRegex);
			        digimonTurn = true;
		        }

		        if (match.Success)
		        {
			        Console.WriteLine(match.Value);
			        str = str.Substring(match.Index + match.Length);
		        }
		        else
			        break;
	        }
        }
    }
}