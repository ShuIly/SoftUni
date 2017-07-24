using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
	class Program
	{
		static void Main(string[] args)
		{

			int match = int.Parse(Console.ReadLine());

			string sequences = "ACGT";
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						// here I'm adding 3 because i, j, k start at 0 instead of 1
						if (i + j + k + 3 >= match) 
						{
							Console.Write("O{0}{1}{2}O ", sequences[i], sequences[j], sequences[k]);
						}
						else
						{
							Console.Write("X{0}{1}{2}X ", sequences[i], sequences[j], sequences[k]);
						}
					}
					Console.WriteLine();
				}
			}
		}
	}
}
