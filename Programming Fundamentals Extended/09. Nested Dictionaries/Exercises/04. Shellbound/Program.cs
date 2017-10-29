using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
	class Program
	{
		static void Main(string[] args)
		{
			var shells = new Dictionary<string, HashSet<int>>();
			string command = Console.ReadLine();

			while (command != "Aggregate")
			{
				string[] shellInfo = command.Split();
				string country = shellInfo[0];
				int shellSize = int.Parse(shellInfo[1]);

				if (!shells.ContainsKey(country))
				{
					shells.Add(country, new HashSet<int>());
				}
				shells[country].Add(shellSize);

				command = Console.ReadLine();
			}

			foreach (KeyValuePair<string, HashSet<int>> currShell in shells)
			{
				HashSet<int> shellSizes = currShell.Value;
				string country = currShell.Key;
				int shellSum = shellSizes.Sum();
				int aggregatedShell = shellSum - shellSum / shellSizes.Count;
				Console.WriteLine("{0} -> {1} ({2})", 
					country, string.Join(", ", shellSizes), aggregatedShell);
			}
		}
	}
}
