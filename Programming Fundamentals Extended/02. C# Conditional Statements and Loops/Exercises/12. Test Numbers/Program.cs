using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int maxSum = int.Parse(Console.ReadLine());

			getSum(N, M, maxSum);

		}
		static void getSum(int N, int M, int maxSum)
		{
			int sum = 0;
			int combinations = 0;
			for (int i = N; i >= 1; i--)
			{
				for (int j = 1; j <= M; j++)
				{
					sum += 3 * i * j;
					combinations++;
					if (sum >= maxSum)
					{
						Console.WriteLine($"{combinations} combinations");
						Console.WriteLine($"Sum: {sum} >= {maxSum}");
						return;
					}
				}
			}
			Console.WriteLine($"{combinations} combinations");
			Console.WriteLine($"Sum: {sum}");
			return;
		}
	}
}
