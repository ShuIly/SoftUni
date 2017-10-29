using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			var clothes = new Dictionary<string, Dictionary<string, int>>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] clothesColorInfo = Console.ReadLine().
					Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				string[] clothesType = clothesColorInfo[1].Split(',');
				string color = clothesColorInfo[0];

				if (!clothes.ContainsKey(color))
				{
					clothes.Add(color, new Dictionary<string, int>());
				}

				int numClothes = clothesType.Length;

				for (int j = 0; j < numClothes; j++)
				{
					string currClothes = clothesType[j];
					if (!clothes[color].ContainsKey(currClothes))
					{
						clothes[color].Add(currClothes, 1);
					}
					else
					{
						clothes[color][currClothes]++;
					}
				}
			}

			string[] searchedClothing = Console.ReadLine().Split();
			string searchedClothingColour = searchedClothing[0];
			string searchedClothingName = searchedClothing[1];

			foreach (KeyValuePair<string, Dictionary<string, int>> item in clothes)
			{
				string color = item.Key;
				Dictionary<string, int> colouredClothes = item.Value;
				Console.WriteLine("{0} clothes:", color);
				foreach (KeyValuePair<string, int> currClothes in colouredClothes)
				{
					string currClothesName = currClothes.Key;
					int currClothesQuantity = currClothes.Value;
					if (color == searchedClothingColour && currClothesName == searchedClothingName)
					{
						Console.WriteLine("* {0} - {1} (found!)", currClothes.Key, currClothes.Value);
					}
					else
					{
						Console.WriteLine("* {0} - {1}", currClothes.Key, currClothes.Value);
					}
				}
			}
		}
	}
}
