using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem
{
	class Program
	{
		static void Main(string[] args)
		{
			string diamond = Console.ReadLine();

			bool inDiamond = false;
			bool outOfLuck = true;

			int diamondCarat = 0;

			foreach (char c in diamond)
			{
				if (c == '<')
				{
					inDiamond = true;
				}
				else if (c == '>' && inDiamond)
				{
					Console.WriteLine($"Found {diamondCarat} carat diamond");
					diamondCarat = 0;
					inDiamond = false;
					outOfLuck = false;
				}

				if (inDiamond && c >= '0' && c <= '9')
				{
					diamondCarat += (int) char.GetNumericValue(c);
				}
			}

			if (outOfLuck)
			{
				Console.WriteLine("Better luck next time");
			}
		}
	}
}
