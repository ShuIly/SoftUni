using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			int secondNum = int.Parse(Console.ReadLine());
			int magicNum = int.Parse(Console.ReadLine());

			findMagicNum(firstNum, secondNum, magicNum);
		}
		static void findMagicNum(int firstNum, int secondNum, int magicNum)
		{
			int combinations = 0;
			for (int i = secondNum; i >= firstNum; i--)
			{
				for (int j = secondNum; j >= firstNum; j--)
				{
					combinations++;
					if (i + j == magicNum)
					{
						Console.WriteLine($"Number found! {i} + {j} = {i + j}");
						return;
					}
				}
			}
			Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
			return;
		}
	}
}
