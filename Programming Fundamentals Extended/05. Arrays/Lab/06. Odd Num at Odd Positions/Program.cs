using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Num_at_Odd_Positions
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = Console.ReadLine().Split();
			int[] num = new int[numbers.Length];
			for (int i = 0; i < numbers.Length; i++)
			{
				num[i] = int.Parse(numbers[i]);
				if (num[i] % 2 != 0 && i % 2 != 0)
				{
					Console.WriteLine($"Index {i} -> {num[i]}");
				}
			}
		}
	}
}
