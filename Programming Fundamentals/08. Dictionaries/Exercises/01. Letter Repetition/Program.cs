using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
	class Program
	{
		static void Main(string[] args)
		{
			string sentence = Console.ReadLine();
			Dictionary<char, int> charCount = new Dictionary<char, int>();
			int sentenceLength = sentence.Length;

			for (int i = 0; i < sentenceLength; i++)
			{
				char currChar = sentence[i];
				if (!charCount.ContainsKey(currChar))
				{
					charCount.Add(currChar, 1);
				}
				else
				{
					charCount[currChar]++;
				}
			}

			foreach (KeyValuePair<char, int> character in charCount)
			{
				Console.WriteLine($"{character.Key} -> {character.Value}");
			}
		}
	}
}
