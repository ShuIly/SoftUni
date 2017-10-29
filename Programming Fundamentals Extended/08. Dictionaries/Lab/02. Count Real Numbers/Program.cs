using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] num = Console.ReadLine().Split().Select(double.Parse).ToArray();
			SortedDictionary<double, double> numCount = new SortedDictionary<double, double>();
			double numWords = num.Length;

			for (int i = 0; i < numWords; i++)
			{
				double currNum = num[i];
				if (!numCount.ContainsKey(currNum))
				{
					numCount.Add(currNum, 1);
				}
				else
				{
					numCount[currNum]++;
				}
			}

			foreach (KeyValuePair<double, double> word in numCount)
			{
				Console.WriteLine($"{word.Key} -> {word.Value}");
			}
		}
	}
}
