using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence_of_Elements_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringNum = Console.ReadLine().Split();
			int[] num = new int[stringNum.Length];
			bool repeats = true;

			num[0] = int.Parse(stringNum[0]);
			int lastNum = num[0];

			for (int i = 0; i < stringNum.Length; i++)
			{
				num[i] = int.Parse(stringNum[i]);
				if (num[i] == lastNum)
				{
					lastNum = num[i];
				}
				else
				{
					repeats = false;
					break;
				}
			}

			if (repeats)
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
