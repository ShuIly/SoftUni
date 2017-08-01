using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Array_Using_Insertion_Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			InsertionSort(num);

			Console.WriteLine(string.Join(" ", num));
		}

		static void InsertionSort(int[] num)
		{
			int numCount = num.Length;
			for (int i = 0; i < numCount; i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (num[j] < num[j - 1])
					{
						Swap(ref num[j], ref num[j - 1]);
					}
				}
			}
		}

		static void Swap(ref int num1, ref int num2)
		{
			int temp = num1;
			num1 = num2;
			num2 = temp;
		}
	}
}
