using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Consecutive_Equal_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			int numRepeats = 1;

			for (int i = words.Length - 1; i >= 0; i--)
			{
				if (words[i - 1] == words[i])
				{
					++numRepeats;
					if (numRepeats == 3)
					{
						Console.WriteLine("{0} {0} {0}", words[i]);
						break;
					}
				}
				else
				{
					numRepeats = 1;
				}
			}
		}
	}
}
