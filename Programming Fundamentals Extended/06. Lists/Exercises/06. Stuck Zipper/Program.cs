using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> firstList = Console.ReadLine().Split().ToList();
			List<string> secondList = Console.ReadLine().Split().ToList();

			int smallestDigit = FindSmallestDigit(firstList, secondList);
			RemoveBiggerDigits(firstList, smallestDigit);
			RemoveBiggerDigits(secondList, smallestDigit);

			List<string> result = new List<string>();

			int firstListCount = firstList.Count;
			int secondListCount = secondList.Count;

			int maxCount = Math.Max(firstListCount, secondListCount);

			// "zipping" the two lists into result list
			for (int i = 0; i < maxCount; i++)
			{
				if (firstListCount > i)
				{
					result.Add(firstList[i]);
				}
				if (secondListCount > i)
				{
					result.Add(secondList[i]);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}

		// this method removes bigger digit numbers
		static void RemoveBiggerDigits(List<string> list, int smallestDigit)
		{
			for (int i = 0; i < list.Count; i++)
			{
				int currElementLength = list[i].Length;

				if (list[i][0] == '-')
				{
					currElementLength--;
				}

				if (currElementLength > smallestDigit)
				{
					list.RemoveAt(i);
					i--;
				}
			}
		}

		// this method finds the smallest num of digits found
		static int FindSmallestDigit(List<string> firstList, List<string> secondList)
		{
			int firstListCount = firstList.Count;
			int secondListCount = secondList.Count;
			int smallestDigit = firstList[0].Length;

			if (firstList[0][0] == '-')
			{
				smallestDigit--;
			}

			for (int i = 1; i < firstListCount; i++)
			{
				int currNumDigits = firstList[i].Length;

				if (firstList[i][0] == '-')
				{
					currNumDigits--;
				}

				if (smallestDigit > currNumDigits)
				{
					smallestDigit = currNumDigits;
				}
			}

			for (int i = 0; i < secondListCount; i++)
			{
				int currNumDigits = secondList[i].Length;

				if (secondList[i][0] == '-')
				{
					currNumDigits--;
				}

				if (smallestDigit > currNumDigits)
				{
					smallestDigit = currNumDigits;
				}
			}

			return smallestDigit;
		}
	}
}
