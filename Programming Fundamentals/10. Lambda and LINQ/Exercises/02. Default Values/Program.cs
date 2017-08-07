using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> dict = new Dictionary<string, string>();
			string command = Console.ReadLine();
			while (command != "end")
			{
				string[] inputInfo = command
					.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				string currKey = inputInfo[0];
				string currValue = inputInfo[1];

				dict[currKey] = currValue;

				command = Console.ReadLine();
			}

			string defValue = Console.ReadLine();

			// Create temp dictionary so we can modify the original
			Dictionary<string, string> tempDict = new Dictionary<string, string>(dict);
			Dictionary<string, string> defaultDict = new Dictionary<string, string>();

			// Delete "null" key occurences in original dictionary and add 
			// the keys with default values to Default dictionary
			foreach (KeyValuePair<string, string> kvp in tempDict.Where(x => x.Value == "null"))
			{
				string currKey = kvp.Key;
				defaultDict.Add(currKey, defValue);
				dict.Remove(currKey);
			}

			foreach (KeyValuePair<string, string> kvp in dict.OrderByDescending(x => x.Value.Length))
			{
				Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
			}

			foreach (KeyValuePair<string, string> kvp in defaultDict)
			{
				Console.WriteLine($"{kvp.Key} <-> {defValue}");
			}
		}
	}
}
