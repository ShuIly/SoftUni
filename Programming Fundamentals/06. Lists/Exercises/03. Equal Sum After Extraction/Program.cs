using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

			secondList.Sort();

			/*
			   check if and element from the first list 
			   occurs more than once in the second list.
			   Note: the order here matters.
			*/
			for (int i = 1; i < secondList.Count; i++)
			{
				if (secondList[i] == secondList[i - 1] && firstList.Contains(secondList[i]))
				{
					int removeNum = firstList[i];

					// remove all instances of removeNum in first list and second list
					firstList.RemoveAll(a => a == removeNum);
					secondList.RemoveAll(a => a == removeNum);
				}
			}

			// remove elements in the first list from the second list.
			for (int i = 0; i < firstList.Count; i++)
			{
				secondList.Remove(firstList[i]);
			}

			int sumFirstList;
			int sumSecondList;

			if (firstList.Any())
			{
				sumFirstList = firstList.Sum();
			}
			else
			{
				sumFirstList = 0;
			}

			if (secondList.Any())
			{
				sumSecondList = secondList.Sum();
			}
			else
			{
				sumSecondList = 0;
			}

			if (sumFirstList == sumSecondList)
			{
				Console.WriteLine("Yes. Sum: {0}", sumFirstList);
			}
			else
			{
				int difference = Math.Abs(sumFirstList - sumSecondList);
				Console.WriteLine("No. Diff: {0}", difference);
			}
		}
	}
}
