using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Rage_Quit
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<char> uniqueCharacters = new HashSet<char>();
			string str = Console.ReadLine();

			// The resulting message.
			StringBuilder result = new StringBuilder();

			// The non-number part that we will be multiplying to the
			// resulting message.
			StringBuilder currStr = new StringBuilder();

			for (int i = 0; i < str.Length; ++i)
			{
				// If we find a number character we concatenate them
				// until we find a normal character again.
				if (Char.IsNumber(str[i]))
				{
					StringBuilder numStr = new StringBuilder();
					while (i < str.Length && Char.IsNumber(str[i]))
					{
						numStr.Append(str[i]);
						i++;
					}
					// So we avoid skipping the character which stopped
					// the while loop.
					--i;

					int count = int.Parse(numStr.ToString());

					/* 
					 *  Turns out you have to count the unique characters
					 *  only if you USE them in your resulting message.
					 *  That is, if you have '0' in your input, the 
					 *  characters behind it should NOT be added to the 
					 *  unique characters HashSet.
					 */
					if (count > 0)
					{
						string appendStr = currStr.ToString();
						foreach (char c in appendStr)
						{
							if (!uniqueCharacters.Contains(c))
								uniqueCharacters.Add(c);
						}
					}

					for (int j = 0; j < count; j++)
						result.Append(currStr);

					currStr = new StringBuilder();
				}
				else
					currStr.Append(Char.ToUpper(str[i]));
			}

			Console.WriteLine($"Unique symbols used: {uniqueCharacters.Count}\n{result}");
		}
	}
}