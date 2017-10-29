using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Write_to_File
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] punctuations = new char[] { '.', ',', '!', '?', ':' };
			using (StreamReader reader = new StreamReader("sample_text.txt"))
			{
				while (!reader.EndOfStream)
				{
					string sentence = reader.ReadLine();
					LinkedList<char> withoutPunctuation = new LinkedList<char>();
					foreach (char character in sentence)
					{
						if (!punctuations.Contains(character))
						{
							withoutPunctuation.AddLast(character);
						}
					}
					Console.WriteLine(string.Join("", withoutPunctuation));
				}
			}

		}
	}
}
