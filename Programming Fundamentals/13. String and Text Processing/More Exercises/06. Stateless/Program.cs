using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stateless
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> collapseList = new List<string>();
			string input = Console.ReadLine();
			while (input != "collapse")
			{
				string collapseStr = Console.ReadLine();
				while (collapseStr.Length > 0)
				{
					input = input.Replace(collapseStr, String.Empty);
					collapseStr = new string(collapseStr.Skip(1).Take(collapseStr.Length - 2).ToArray());
				}

				input = input.Trim();

				if (input.Length == 0)
				{
					collapseList.Add("(void)");
				}
				else
				{
					collapseList.Add(input);
				}
				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(Environment.NewLine, collapseList));
		}
	}
}
