using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deserialize_String
{
	class Program
	{
		static void Main(string[] args)
		{
			var charPos = new Dictionary<char, List<int>>();
			string input = Console.ReadLine();
			int maxPos = -1;
			while (input != "end")
			{
				string[] inputTokens = input
					.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
				char c = char.Parse(inputTokens[0]);

				if (!charPos.ContainsKey(c))
				{
					charPos.Add(c, new List<int>());
				}

				for (int i = 1; i < inputTokens.Length; i++)
				{
					int pos = int.Parse(inputTokens[i]);
					if (pos > maxPos)
						maxPos = pos;
					charPos[c].Add(int.Parse(inputTokens[i]));
				}

				input = Console.ReadLine();
			}

			StringBuilder sb = new StringBuilder(new string(' ', maxPos + 1));
			foreach (char c in charPos.Keys)
			{
				foreach (int index in charPos[c])
				{
					sb[index] = c;
				}
			}

			Console.WriteLine(sb);
		}
	}
}
