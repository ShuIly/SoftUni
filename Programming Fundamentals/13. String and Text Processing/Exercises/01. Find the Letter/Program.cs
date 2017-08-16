using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Find_the_Letter
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string[] letterPos = Console.ReadLine().Split();
			char letter = char.Parse(letterPos[0]);
			int pos = int.Parse(letterPos[1]);

			int lastIndex = -1;
			int count = 0;
			while (count < pos && (lastIndex = text.IndexOf(letter, lastIndex + 1)) != -1)
				count++;

			if (count != pos)
			{
				Console.WriteLine("Find the letter yourself!");
			}
			else
			{
				Console.WriteLine(lastIndex);
			}
		}
	}
}
