using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = Console.ReadLine().Split();
			int[] num = new int[numbers.Length];
			int numOdd = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				num[i] = int.Parse(numbers[i]);
				if (num[i] % 2 != 0)
				{
					numOdd++;
				}
			}
			Console.WriteLine(numOdd);
		}
	}
}
