using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inputList = new List<string>();
			using (StreamReader reader = new StreamReader("FileOne.txt"))
			{
				while (!reader.EndOfStream)
				{
					inputList.Add(reader.ReadLine());
				}
			}

			using (StreamReader reader = new StreamReader("FileTwo.txt"))
			{
				while (!reader.EndOfStream)
				{
					inputList.Add(reader.ReadLine());
				}
			}

			Console.WriteLine(string.Join(Environment.NewLine, inputList));
		}
	}
}
