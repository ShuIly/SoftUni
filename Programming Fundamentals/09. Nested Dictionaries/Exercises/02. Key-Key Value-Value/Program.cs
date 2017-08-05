using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_Key_Value_Value
{
	class Program
	{
		static void Main(string[] args)
		{
			string key = Console.ReadLine();
			string value = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());

			var keyValuePairs = new Dictionary<string, HashSet<string>>();

			for (int i = 0; i < n; i++)
			{
				string[] keyValueInput = Console.ReadLine()
					.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
				string inputKey = keyValueInput[0];
				string[] inputValues = keyValueInput[1].Split(';');

				if (inputKey.Contains(key))
				{
					if (!keyValuePairs.ContainsKey(inputKey))
					{
						keyValuePairs.Add(inputKey, new HashSet<string>());
					}
					int inputValueCount = inputValues.Length;
					for (int j = 0; j < inputValueCount; j++)
					{
						string currInputValue = inputValues[j];
						if (currInputValue.Contains(value))
						{
							keyValuePairs[inputKey].Add(currInputValue);
						}
					}
				}
			}

			foreach (KeyValuePair<string, HashSet<string>> currPair in keyValuePairs)
			{
				string currPairKey = currPair.Key;
				HashSet<string> currPairValues = currPair.Value;
				Console.WriteLine("{0}:", currPairKey);
				foreach (string currMatchingKey in currPairValues)
				{
					Console.WriteLine("-{0}", currMatchingKey);
				}
			}
		}
	}
}
