using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] toNine = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
				"seventeen", "eighteen", "nineteen" };
			string[] thies = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(Console.ReadLine());
				if (num > 999)
				{
					Console.Write("too large");
				}
				else if (num < -999)
				{
					Console.Write("too small");
				}
				else if (num >= 100 || num <= -100)
				{
					if (num < 0)
					{
						Console.Write("minus ");
						num = Math.Abs(num);
					}

					int firstNum = num / 100;
					Console.Write($"{toNine[firstNum - 1]}-hundred");

					int lastTwoNums = num % 100;
					if (lastTwoNums >= 20)
					{
						// here we find the string array indexes.
						int indexThies = lastTwoNums / 10 - 2;
						if (lastTwoNums % 10 == 0)
						{
							Console.Write($" and {thies[indexThies]}");
						}
						else
						{
							int indexToNine = lastTwoNums % 10 - 1;
							Console.Write($" and {thies[indexThies]} {toNine[indexToNine]}");
						}
					}
					else if (lastTwoNums >= 10)
					{
						int index = lastTwoNums - 10;
						Console.Write($" and {teens[index]}");
					}
					else if (lastTwoNums > 0)
					{
						int index = lastTwoNums - 1;
						Console.Write($" and {toNine[index]}");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
