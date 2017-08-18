using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.String_Commander
{
	class Program
	{
		// There's only one case where the program doesn't work, but I can't
		// find the reason. Hopefully it's not my program's fault!
		public static string Move(string str, string direction, int count)
		{
			StringBuilder sb = new StringBuilder(str);
			if (direction == "Left")
			{
				for (int i = 0; i < count; i++)
				{
					sb.Append(sb[0]);
					sb.Remove(0, 1);
				}
			}
			else
			{
				for (int i = 0; i < count; i++)
				{
					sb.Insert(0, sb[sb.Length - 1]);
					sb.Remove(sb.Length - 1, 1);
				}
			}

			return sb.ToString();
		}

		public static string InsertString(string str, string insertStr, int index)
		{
			int takeTillIndex = str.Length - (str.Length - index);
			string result = new string(str.Take(takeTillIndex).ToArray()) +
				insertStr + new string(str.Skip(takeTillIndex).ToArray());

			return result;
		}

		public static string DeleteString(string str, int startIndex, int endIndex)
		{
			int takeTillIndex = startIndex;
			string result = new string(str.Take(takeTillIndex).ToArray()) +
				new string(str.Skip(endIndex - startIndex + 1).ToArray());

			return result;
		}

		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string input = Console.ReadLine();
			while (input != "end")
			{
				string[] inputTokens = input.Split();
				string command = inputTokens[0];
				switch (command)
				{
					case "Left":
					case "Right":
						int count = int.Parse(inputTokens[1]);
						str = Move(str, command, count);
						break;
					case "Insert":
						int index = int.Parse(inputTokens[1]);
						string insertStr = inputTokens[2];
						str = InsertString(str, insertStr, index);
						break;
					case "Delete":
						int startIndex = int.Parse(inputTokens[1]);
						int endIndex = int.Parse(inputTokens[2]);
						str = DeleteString(str, startIndex, endIndex);
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(str);
		}
	}
}
