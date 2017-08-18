using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Serialize_String
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<char> checkedChar = new HashSet<char>();
			string input = Console.ReadLine();
			foreach (char c in input)
			{
				if (!checkedChar.Contains(c))
				{
					List<int> charPos = new List<int>();
					int lastIndex = -1;

					while ((lastIndex = input.IndexOf(c, lastIndex + 1)) != -1)
						charPos.Add(lastIndex);

					Console.WriteLine("{0}:{1}", c, string.Join("/", charPos));
					checkedChar.Add(c);
				}
			}
		}
	}
}
