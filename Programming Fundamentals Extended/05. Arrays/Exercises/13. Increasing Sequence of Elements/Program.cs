using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence_of_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringNum = Console.ReadLine().Split();
			int[] num = new int[stringNum.Length];
			bool isAscending = true;

			num[0] = int.Parse(stringNum[0]);
			int lastNum = num[0];
			
			for (int i = 1; i < stringNum.Length; i++)
			{
				num[i] = int.Parse(stringNum[i]);
				if (lastNum <= num[i])
				{
					lastNum = num[i];
				}
				else
				{
					isAscending = false;
					break;
				}
			}

			if (isAscending)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
