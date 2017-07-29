using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
	class Program
	{
		static void Main(string[] args)
		{
			// basicly split by any of these characters and remove empty whitespaces
			string[] words = Console.ReadLine().Split(new char[]
			{ ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, 
			StringSplitOptions.RemoveEmptyEntries).ToArray();

			List<string> lowerCase = new List<string>();
			List<string> mixedCase = new List<string>();
			List<string> upperCase = new List<string>();


			for (int i = 0; i < words.Length; i++)
			{
				char[] word = words[i].ToCharArray();
				bool hasUpper = word.Any(a => char.IsUpper(a));
				bool hasLower = word.Any(a => char.IsLower(a));
				bool hasOnlyLetters = word.All(Char.IsLetter);

				if (hasLower && !hasUpper && hasOnlyLetters)
				{
					lowerCase.Add(words[i]); 
				}
				else if (hasUpper && !hasLower && hasOnlyLetters)
				{
					upperCase.Add(words[i]); 
				}
				else
				{
					mixedCase.Add(words[i]);
				}
			}

			Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
			Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
			Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
		}
	}
}
