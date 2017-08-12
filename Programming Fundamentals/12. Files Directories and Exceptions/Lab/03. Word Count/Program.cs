using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> wordCount = new Dictionary<string, int>();
			List<string> inputString = new List<string>();
			using (StreamReader wordReader = new StreamReader("words.txt"))
			{
				while (!wordReader.EndOfStream)
				{
					string[] words = wordReader
						.ReadToEnd()
						.ToLower()
						.Split();

					for (int i = 0; i < words.Length; i++)
					{
						wordCount[words[i]] = 1;
					}
				}
			}

			using (StreamReader inputReader = new StreamReader("text.txt"))
			{
				while (!inputReader.EndOfStream)
				{
					string[] words = inputReader
						.ReadToEnd()
						.ToLower()
						.Split();

					foreach (string word in words)
					{
						if (wordCount.ContainsKey(word))
						{
							wordCount[word]++;
						}
					}
				}
			}

			foreach (var word in wordCount
				.OrderByDescending(w => w.Value))
			{
				Console.WriteLine($"{word.Key} - {word.Value}");
			}
		}
	}
}
