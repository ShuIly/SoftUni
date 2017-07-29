using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction_V2
{
	class Program
	{
		public static void Main()
		{

			var firstListOfInt = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.OrderBy(x => x)
				.ToList();

			var secondListOfInt = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.OrderBy(x => x)
				.ToList();

			foreach (var item in firstListOfInt)
			{
				secondListOfInt.Remove(item);
			}

			var sumFirts = firstListOfInt.Sum();
			var sumSecond = secondListOfInt.Sum();
			var diff = Math.Abs(sumFirts - sumSecond);
			if (sumFirts == sumSecond)
			{
				Console.WriteLine($"Yes. Sum: {sumFirts}");
			}
			else
			{
				Console.WriteLine($"No. Diff: {diff}");
			}

		}
	}
}
