using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			int numOfUpper = 0;

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length == 1)
				{
					char letter = Convert.ToChar(words[i]);
					if (char.IsUpper(letter))
					{
						numOfUpper++;
					}
				}
			}
			Console.WriteLine(numOfUpper);
		}
	}
}
