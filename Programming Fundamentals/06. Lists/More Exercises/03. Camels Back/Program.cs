using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camels_Back
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int stableSize = int.Parse(Console.ReadLine());
			int numLength = num.Length;

			if (numLength == stableSize)
			{
				Console.WriteLine("already stable: {0}", string.Join(" ", num));
			}
			else
			{
				int rounds = (numLength - stableSize) / 2;
				Console.WriteLine("{0} rounds", rounds);
				Console.WriteLine("remaining: {0}", string.Join(" ", 
					num.Skip(rounds).Take(numLength - rounds * 2)));
			}
		}
	}
}
