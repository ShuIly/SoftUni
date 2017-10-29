using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string asciiString = "";
			for (int i = 0; i < n; i++)
			{
				byte asciiNum = byte.Parse(Console.ReadLine());
				asciiString += (char) asciiNum;
			}
			Console.WriteLine(asciiString);
		}
	}
}
