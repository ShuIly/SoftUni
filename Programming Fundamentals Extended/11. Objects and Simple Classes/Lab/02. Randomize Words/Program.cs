using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			Random rnd = new Random();

			int wordsCount = words.Length;
			for (int i = 0; i < wordsCount; i++)
			{
				int rndIndex = rnd.Next(wordsCount);
				string temp = words[rndIndex];
				words[rndIndex] = words[i];
				words[i] = temp;
			}

			Console.WriteLine(string.Join(Environment.NewLine, words));
		}
	}
}
