using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negative_Elements_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] num = new int[n];
			int negativeNums = 0;

			for (int i = 0; i < n; i++)
			{
				num[i] = int.Parse(Console.ReadLine());
				if (num[i] < 0)
				{
					++negativeNums;
				}
			}
			Console.WriteLine(negativeNums);
		}
	}
}
