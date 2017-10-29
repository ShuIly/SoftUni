using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Filter_Extensions
{
	class Program
	{
		static void Main(string[] args)
		{
			string extention = Console.ReadLine();
			string[] files = Directory.GetFiles("input", $"*.{extention}");

			foreach (string file in files)
			{
				Console.WriteLine(Path.GetFileName(file));
			}
		}
	}
}
