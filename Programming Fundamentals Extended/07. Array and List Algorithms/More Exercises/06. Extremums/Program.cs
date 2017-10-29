using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extremums
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			string order = Console.ReadLine();
			List<int> rotatedList = new List<int>();

			int numCount = num.Length;

			// Create a list with rotated numbers
			for (int i = 0; i < numCount; i++)
			{
				rotatedList.Add(GetRotatedNum(num[i], order));
			}

			int sumRotatedNumbers = rotatedList.Sum();
			Console.WriteLine(string.Join(", ", rotatedList));
			Console.WriteLine(sumRotatedNumbers);
		}

		static int GetRotatedNum(int num, string order)
		{
			List<int> digitList = new List<int>();

			// Create list of digits
			while (num > 0)
			{
				int currDigit = num % 10;
				digitList.Add(num % 10);
				num /= 10;
			}

			int maxNum = -1;
			int minNum = int.MaxValue;
			int digitListCount = digitList.Count;

			// Rotate the list while finding maxNum and minNum
			for (int i = 0; i < digitListCount; i++)
			{
				int currNum = 0;
				int multiplier = 1;

				// Create current number with the digits from digitList
				for (int j = 0; j < digitListCount; j++)
				{
					currNum += digitList[j] * multiplier;
					multiplier *= 10;
				}

				// Compare current number with maxNum and minNum
				if (currNum > maxNum)
				{
					maxNum = currNum;
				}

				if (currNum < minNum)
				{
					minNum = currNum;
				}

				// Rotate the digits in digitList
				int rotateNum = digitList[0];
				digitList.RemoveAt(0);
				digitList.Add(rotateNum);
			}

			if (order == "Max")
			{
				return maxNum;
			}
			else
			{
				return minNum;
			}
		}
	}
}
