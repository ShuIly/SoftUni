using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Legendary_Farming
{
	class Program
	{
		static void Main(string[] args)
		{
			var materials = new SortedDictionary<string, int>();
			var rareMaterials = new Dictionary<string, int>
			{
				{ "shards", 0 },
				{ "fragments", 0 },
				{ "motes", 0 },
			};

			string result = "";
			bool legendaryObtained = false;

			while (!legendaryObtained)
			{
				string[] inputTokens = Console.ReadLine()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				for (int i = 0; i < inputTokens.Length; i += 2)
				{
					// If we already obtained a legendary but we must
					// wait for end of input.
					if (legendaryObtained)
						break;

					string materialName = inputTokens[i + 1].ToLower();
					int quantity = int.Parse(inputTokens[i]);

					if (materialName == "shards" ||
						materialName == "fragments" ||
						materialName == "motes")
					{
						rareMaterials[materialName] += quantity;

						if (rareMaterials[materialName] >= 250)
						{
							switch (materialName)
							{
								case "shards":
									result += "Shadowmourne obtained!\n";
									break;
								case "fragments":
									result += "Valanyr obtained!\n";
									break;
								case "motes":
									result += "Dragonwrath obtained!\n";
									break;
							}

							legendaryObtained = true;
							rareMaterials[materialName] -= 250;
						}
					}
					else
					{
						if (!materials.ContainsKey(materialName))
							materials.Add(materialName, quantity);
						else
							materials[materialName] += quantity;
					}
				}
			}

			foreach (var rareMaterial in rareMaterials
				.OrderByDescending(rm => rm.Value)
				.ThenBy(rm => rm.Key))
				result += $"{rareMaterial.Key}: {rareMaterial.Value}\n";

			foreach (var material in materials)
				result += $"{material.Key}: {material.Value}\n";

			Console.WriteLine(result);
		}
	}
}