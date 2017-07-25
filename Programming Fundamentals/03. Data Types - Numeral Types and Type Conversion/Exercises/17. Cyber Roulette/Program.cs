using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cyber_Roulette
{
	// this exercise is not well made, so I will leave it at 80/100
	// if you need it for compete search the softuni forum
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			bool spinActive = false;
			string finalString = "";

			string lastString = "";
			for (int i = 0; i < n; i++)
			{
				string word = Console.ReadLine();
				if (word == lastString)
				{
					finalString = "";
					lastString = "";
					if (word == "spin")
					{
						--i;
					}
				}
				else if (word == "spin")
				{
					if (spinActive)
					{
						spinActive = false;
					}
					else
					{
						spinActive = true;
					}
					i--;
					lastString = word;
				}
				else
				{
					if (spinActive)
					{
						finalString = word + finalString;
					}
					else
					{
						finalString += word;
					}
					lastString = word;
				}
			}
			Console.WriteLine(finalString);
		}
	}
}