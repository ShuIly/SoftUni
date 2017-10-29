using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int numCount = num.Length;
			bool isSorted = false;

			while (!isSorted)
			{
				isSorted = true;
				for (int i = 0; i < numCount - 1; i++)
				{
					if (num[i] > num[i + 1])
					{
						Swap(ref num[i], ref num[i + 1]);
						isSorted = false;
					}
				}
			}

			Console.WriteLine(string.Join(" ", num));
		}

		static void Swap(ref int num1, ref int num2)
		{
			int temp = num1;
			num1 = num2;
			num2 = temp;
		}
	}
}
