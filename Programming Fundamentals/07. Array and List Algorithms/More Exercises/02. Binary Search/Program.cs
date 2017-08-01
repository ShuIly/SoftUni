using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_Search
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
			int searchedNum = int.Parse(Console.ReadLine());
			num.Sort();
			

			int[] getInfo = BinarySearch(num, searchedNum);
			if (getInfo[1] == -1)
			{
				Console.WriteLine("No");
				Console.WriteLine("Linear search made {0} iterations", num.Count);
			}
			else
			{
				int foundIndex = LinearSearch(num, searchedNum);
				Console.WriteLine("Yes");
				Console.WriteLine("Linear search made {0} iterations", foundIndex + 1);
			}
			Console.WriteLine("Binary search made {0} iterations", getInfo[0]);
		}

		static int[] BinarySearch(List<int> num, int searchedNum)
		{
			int left = 0;
			int right = num.Count - 1;

			int[] output = new int[2];
			output[1] = -1;

			while (left <= right)
			{
				int middle = (left + right) / 2;
				output[0]++;

				if (num[middle] == searchedNum)
				{
					output[1] = middle;
					return output;
				}
				else if (num[middle] > searchedNum)
				{
					right = middle - 1;
				}
				else
				{
					left = middle + 1;
				}
			}

			return output;
		}

		static int LinearSearch(List<int> num, int searchedNum)
		{
			int foundIndex = 0;
			int numCount = num.Count;
			for (int i = 0; i < numCount; i++)
			{
				if (searchedNum == num[i])
				{
					foundIndex = i;
					break;
				}
			}

			return foundIndex;
		}
	}
}
