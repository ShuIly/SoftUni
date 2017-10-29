using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = Console.ReadLine().Split();
			string[] names = Console.ReadLine().Split();
			string command =Console.ReadLine();

			while (command != "done")
			{
				for (int i = 0; i < names.Length; i++)
				{
					if (names[i] == command)
					{
						Console.WriteLine("{0} -> {1}", names[i], numbers[i]);
					}
				}
				command = Console.ReadLine();
			}
		}
	}
}
