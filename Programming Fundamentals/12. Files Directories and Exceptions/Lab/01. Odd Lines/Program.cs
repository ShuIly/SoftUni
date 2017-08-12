using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Lines
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inputString = new List<string>();
			using (StreamReader reader = new StreamReader("input.txt"))
			{
				while (!reader.EndOfStream)
				{
					inputString.Add(reader.ReadLine());
				}
			}

			for (int i = 1; i < inputString.Count; i += 2)
			{
				Console.WriteLine(inputString[i]);
			}
		}
	}
}
