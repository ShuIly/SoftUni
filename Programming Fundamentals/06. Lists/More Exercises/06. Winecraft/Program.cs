using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
	class Program
	{
		public static void Main()
		{
			// honestly I have no idea why test 5 is wrong so I'll leave it at 88/100. If you
			// want it solved fully search in github
			int[] grapes = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int rounds = int.Parse(Console.ReadLine()); // n

			int grapesCounter = grapes.Length;
			int countRound = 0;

			//---spin for each season until the grapes are less than rounds---
			while (grapesCounter >= rounds)
			{
				//---count the rounds---
				for (int counter = 0; counter < rounds; counter++)
				{
					// -1 => lesser, 0 => normal, 1 => greater
					var grapesKind = new int[grapes.Length];
					for (int index = 1; index < grapes.Length - 1; index++)
					{
						if (grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1])
						{
							grapesKind[index] = 1;
							grapesKind[index - 1] = -1;
							grapesKind[index + 1] = -1;
							index++;
						}
					}

					//---calculate the grapes---
					for (int index = 0; index < grapes.Length; index++)
					{
						if (grapesKind[index] == 0 && grapes[index] > 0)
						{
							grapes[index]++;
						}
						else if (grapesKind[index] == 1)
						{
							grapes[index]++;
							if (grapes[index - 1] > 0)
							{
								grapes[index]++;
								grapes[index - 1]--;
							}
							if (grapes[index + 1] > 0)
							{
								grapes[index]++;
								grapes[index + 1]--;
							}
							index++;
						}
					}

					countRound++;
					if (countRound == rounds)
					{
						grapesCounter = grapes.Length;
						for (int index = 0; index < grapes.Length; index++)
						{
							if (grapes[index] <= rounds)
							{
								grapes[index] = 0;
								grapesCounter--;
							}
						}
						countRound = 0;
					}
				}
			}
			Console.WriteLine(string.Join(" ", grapes.Where(x => x > rounds)));
		}
	}
}
