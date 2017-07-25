using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			char firstLetter = 'a';
			char endLetter = (char) (firstLetter + n);
			for (char i = firstLetter; i < endLetter; i++)
			{
				for (char j = firstLetter; j < endLetter; j++)
				{
					for (char k = firstLetter; k < endLetter; k++)
					{
						Console.WriteLine($"{i}{j}{k}");
					}
				}
			}
		}
	}
}
