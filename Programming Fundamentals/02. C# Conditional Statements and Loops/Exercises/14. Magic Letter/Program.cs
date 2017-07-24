using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstLetter = char.Parse(Console.ReadLine());
			char secondLetter = char.Parse(Console.ReadLine());
			char noPrint = char.Parse(Console.ReadLine());

			if (firstLetter > secondLetter)
			{
				char temp = firstLetter;
				firstLetter = secondLetter;
				secondLetter = temp;
			}

			for (char i = firstLetter; i <= secondLetter; i++)
			{
				if (i == noPrint)
				{
					continue;
				}
				for (char j = firstLetter; j <= secondLetter; j++)
				{
					if (j == noPrint)
					{
						continue;
					}
					for (char k = firstLetter; k <= secondLetter; k++)
					{
						if (k == noPrint)
						{
							continue;
						}
						Console.Write($"{i}{j}{k} ");
					}
				}
			}
				Console.WriteLine();
		}
	}
}
