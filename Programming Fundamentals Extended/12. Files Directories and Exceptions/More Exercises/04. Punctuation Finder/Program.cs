using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Punctuation_Finder
{
	class Program
	{
		static void Main(string[] args)
		{
			List<char> foundPuctList = new List<char>();
			char[] punctuations = new char[] { '.', ',', '!', '?', ':' };
			using (StreamReader reader = new StreamReader("sample_text.txt"))
			{
				while (!reader.EndOfStream)
				{
					string sentence = reader.ReadLine();
					foreach (char character in sentence)
					{
						if (punctuations.Contains(character))
						{
							foundPuctList.Add(character);
						}
					}
				}
			}

			Console.WriteLine(string.Join(", ", foundPuctList));
		}
	}
}
