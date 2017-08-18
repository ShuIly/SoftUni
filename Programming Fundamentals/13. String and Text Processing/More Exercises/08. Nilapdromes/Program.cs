using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nilapdromes
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "end")
			{
				int halfLength = input.Length / 2;
				string side = "";
				for (int i = 0; i < halfLength; i++)
				{
					string substr = new string(input.Take(i + 1).ToArray());
					if (input.IndexOf(substr, input.Length - 1 - i) != -1)
					{
						side = substr;
					}
				}

				if (side.Length > 0)
				{
					string core = new string(input
						.Skip(side.Length)
						.Take(input.Length - 2 * side.Length)
						.ToArray());

					string nilapdrome = core + side + core;
					Console.WriteLine(nilapdrome);
				}

				input = Console.ReadLine();
			}
		}
	}
}
