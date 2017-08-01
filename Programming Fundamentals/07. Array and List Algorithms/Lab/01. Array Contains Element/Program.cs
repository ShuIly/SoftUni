using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int searchNum = int.Parse(Console.ReadLine());

			int numCount = num.Length;
			bool foundNum = false;

			for (int i = 0; i < numCount; i++)
			{
				if (num[i] == searchNum)
				{
					foundNum = true;
					break;
				}
			}

			if (foundNum)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
