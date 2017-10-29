using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
	class Program
	{
		static void Main(string[] args)
		{
			var dict = new Dictionary<string, List<int>>();
			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] subCommands = command.Split(new string[] { " -> " },
					StringSplitOptions.RemoveEmptyEntries);
				string name = subCommands[0];
				string[] numOrRef = subCommands[1].Split(',');

				int numOrRefCount = numOrRef.Length;
				for (int i = 0; i < numOrRefCount; i++)
				{
					int currNum;
					string currNumOrRef = numOrRef[i];

					// There is no need to check the entire array for names,
					// but I think this adds a nice functionality.
					// For example, what if the input was "John, 2, 3"?
					if (int.TryParse(currNumOrRef, out currNum))
					{
						if (!dict.ContainsKey(name))
						{
							dict.Add(name, new List<int>());
						}
						dict[name].Add(currNum);
					}
					else if (dict.ContainsKey(currNumOrRef))
					{
						dict[name] = new List<int>(dict[numOrRef[i]]);
					}
				}
				command = Console.ReadLine();
			}

			foreach (KeyValuePair<string, List<int>> person in dict)
			{
				Console.WriteLine("{0} === {1}", person.Key, string.Join(", ", person.Value));
			}
		}
	}
}
