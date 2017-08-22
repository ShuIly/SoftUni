using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Fish_Statistics
{
	class Program
	{
		static void Main(string[] args)
		{
			string regex = @">*?<\(+?[\'x-]>";
			string input = Console.ReadLine();
			string[] fishes = Regex.Matches(input, regex)
				.Cast<Match>()
				.Select(m => m.Value)
				.ToArray();

			if (fishes.Length > 0)
			{
				int index = 1;
				foreach (string fish in fishes)
				{
					Console.WriteLine($"Fish {index}: {fish}");

					// Of course we could find tail length and body length with Regex
					// but that would be a lot slower
					int tailLength = 0;
					while (fish[tailLength] == '>')
						++tailLength;

					if (tailLength > 5)
					{
						Console.WriteLine("Tail type: Long ({0} cm)", tailLength * 2);
					}
					else if (tailLength > 1)
					{
						Console.WriteLine("Tail type: Medium ({0} cm)", tailLength * 2);
					}
					else if (tailLength == 1)
					{
						Console.WriteLine("Tail type: Short ({0} cm)", tailLength * 2);
					}
					else
					{
						Console.WriteLine("Tail type: None");
					}

					int bodyLength = fish.Length - tailLength - 3;
					if (bodyLength > 10)
					{
						Console.WriteLine("Body type: Long ({0} cm)", bodyLength * 2);
					}
					else if (bodyLength > 5)
					{
						Console.WriteLine("Body type: Medium ({0} cm)", bodyLength * 2);
					}
					else
					{
						Console.WriteLine("Body type: Short ({0} cm)", bodyLength * 2);
					}

					char fishEye = fish[fish.Length - 2];
					switch (fishEye)
					{
						case '\'':
							Console.WriteLine("Status: Awake");
							break;
						case '-':
							Console.WriteLine("Status: Asleep");
							break;
						case 'x':
							Console.WriteLine("Status: Dead");
							break;
					}

					index++;
				}
			}
			else
			{
				Console.WriteLine("No fish found.");
			}
		}
	}
}
