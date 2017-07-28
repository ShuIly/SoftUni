using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] symbol = Console.ReadLine().ToCharArray();
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < symbol.Length; i++)
			{
				if (num[i] % 2 == 0)
				{
					symbol[i] -= (char) num[i];
				}
				else
				{
					symbol[i] += (char) num[i];
				}
			}

			Console.WriteLine(symbol);
		}
	}
}
