using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int numCount = num.Length;

			for (int i = 0, j = numCount - 1; i <= j; i++, j--)
			{
				int temp = num[i];
				num[i] = num[j];
				num[j] = temp;
			}

			Console.WriteLine(string.Join(" ", num));
		}
	}
}
