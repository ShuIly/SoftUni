using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Digits_with_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string digitWord = Console.ReadLine();
			int digitNum = 0;
			switch (digitWord.ToLower())
			{
				case "one":
					digitNum = 1;
					break;
				case "two":
					digitNum = 2;
					break;
				case "three":
					digitNum = 3;
					break;
				case "four":
					digitNum = 4;
					break;
				case "five":
					digitNum = 5;
					break;
				case "six":
					digitNum = 6;
					break;
				case "seven":
					digitNum = 7;
					break;
				case "eight":
					digitNum = 8;
					break;
				case "nine":
					digitNum = 9;
					break;
			}
			Console.WriteLine(digitNum);
		}
	}
}
