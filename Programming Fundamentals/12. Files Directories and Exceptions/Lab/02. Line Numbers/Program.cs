using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inputList = new List<string>();
			using (StreamReader reader = new StreamReader("input.txt"))
			{
				int lineIndex = 1;
				while (!reader.EndOfStream)
				{
					string indexedLine = string.Format($"{lineIndex}. {reader.ReadLine()}");
					inputList.Add(indexedLine);
					lineIndex++;
				}
			}

			Console.WriteLine(string.Join(Environment.NewLine, inputList));
		}
	}
}
