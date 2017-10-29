using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] bannedWords = Console.ReadLine()
				.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
			string text = Console.ReadLine();

			foreach (var word in bannedWords)
			{
				while (text.Contains(word))
				{
					text = text.Replace(word, new string('*', word.Length));
				}
			}

			Console.WriteLine(text);
		}
	}
}
