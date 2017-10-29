using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> dict = new Dictionary<string, int>();
			string[] str = Console.ReadLine().Split();

			while (str[0] != "end")
			{
				try
				{
					dict[str[0]] = int.Parse(str[2]);
				}
				catch
				{
					if (dict.ContainsKey(str[2]))
					{
						dict[str[0]] = dict[str[2]];
					}
				}
				str = Console.ReadLine().Split();
			}

			foreach (KeyValuePair<string, int> item in dict)
			{
				Console.WriteLine($"{item.Key} === {item.Value}");
			}
		}
	}
}
