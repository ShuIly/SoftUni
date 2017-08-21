using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Booming_Cannon
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> hitList = new List<string>();
			string[] fireInfo = Console.ReadLine().Split();
			string input = Console.ReadLine();

			int fireDistance = int.Parse(fireInfo[0]);
			int blastDiameter = int.Parse(fireInfo[1]);

			string regex = @"(?<=\\<<<)[^\\<<<].*?(?:(?=\\<<<)|$)";
			string[] targets = Regex.Matches(input, regex)
				.Cast<Match>()
				.Select(m => m.Value)
				.ToArray();

			foreach (string target in targets)
			{
				int remainingArea = target.Length - fireDistance;
				if (remainingArea > 0)
				{
					int areaAfterBlast = remainingArea - blastDiameter;
					string blastString;
					if (areaAfterBlast <= 0)
					{
						blastString = target.Substring(fireDistance);
					}
					else
					{
						blastString = target.Substring(fireDistance, blastDiameter);
					}

					hitList.Add(blastString);
				}
			}

			Console.WriteLine(string.Join("/\\", hitList));
		}
	}
}
