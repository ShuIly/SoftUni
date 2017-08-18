using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Pyramidic
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[] lines = new string[n];
			HashSet<char> checkedChars = new HashSet<char>();

			for (int i = 0; i < n; i++)
			{
				lines[i] = Console.ReadLine();
			}

			int maxNumChars = 0;
			char maxChar = ' ';
			for (int i = 0; i < n; i++)
			{
				foreach (char c in lines[i])
				{
					if (!checkedChars.Contains(c))
					{
						checkedChars.Add(c);
						int numChars = 3;
						for (int j = i + 1; j < n; j++)
						{
							if (lines[j].Contains(new string(c, numChars)))
							{
								if (numChars > maxNumChars)
								{
									maxNumChars = numChars;
									maxChar = c;
								}
								numChars += 2;
							}
							else
							{
								numChars = 1;
							}
						}
					}
				}
			}

			for (int i = 1; i <= maxNumChars; i += 2)
			{
				Console.WriteLine(new string(maxChar, i));
			}
		}
	}
}
