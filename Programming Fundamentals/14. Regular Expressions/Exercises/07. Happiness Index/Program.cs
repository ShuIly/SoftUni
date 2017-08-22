using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Happiness_Index
{
	class Program
	{
		static void Main(string[] args)
		{
			string smileyPattern = @":\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;";
			string sadFacePattern = @":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|]:|];";
			string input = Console.ReadLine();
			int smileyCount = Regex.Matches(input, smileyPattern).Count;
			int sadFaceCount = Regex.Matches(input, sadFacePattern).Count;
			double happinessIndex = (double)smileyCount / sadFaceCount;
			if (happinessIndex >= 2)
			{
				Console.WriteLine($"Happiness index: {happinessIndex:F2} :D");
			}
			else if (happinessIndex > 1)
			{
				Console.WriteLine($"Happiness index: {happinessIndex:F2} :)");
			}
			else if (happinessIndex == 1)
			{
				Console.WriteLine($"Happiness index: {happinessIndex:F2} :|");
			}
			else
			{
				Console.WriteLine($"Happiness index: {happinessIndex:F2} :(");
			}

			Console.WriteLine($"[Happy count: {smileyCount}, Sad count: {sadFaceCount}]");
		}
	}
}
