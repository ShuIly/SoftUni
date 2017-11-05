using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _02.Anonymous_Threat
{
	class Program
	{
		static List<string> text;

		static void MergePartitions(int startIndex, int endIndex)
		{
			if (startIndex < 0)
				startIndex = 0;

			if (startIndex >= text.Count)
				startIndex = text.Count - 1;

			if (endIndex >= text.Count)
				endIndex = text.Count - 1;

			StringBuilder result = new StringBuilder();
			for (int i = startIndex; i <= endIndex; i++)
				result.Append(text[i]);

			text.RemoveRange(startIndex, endIndex - startIndex + 1);
			text.Insert(startIndex, result.ToString());
		}

		static void DivideToPartitions(int index, int partitions)
		{
			string textToDivide = text[index];
			string[] dividedString = new string[partitions];

			if (textToDivide.Length % partitions == 0)
			{
				int divLength = textToDivide.Length / partitions;
				int divStringIndex = 0;

				for (int i = 0; i < partitions; i++)
				{
					dividedString[i] = textToDivide.Substring(divStringIndex, divLength);
					divStringIndex += divLength;
				}
			}
			else
			{
				int smallLength = 1;
				int bigLength = textToDivide.Length - smallLength * (partitions - 1);
				while (smallLength < bigLength)
				{
					smallLength++;
					bigLength -= partitions - 1;
				}

				smallLength--;
				bigLength += partitions - 1;

				int smallPartitionCount = partitions - 1;
				int dividedStringIndex = 0;
				for (int i = 0; i < smallPartitionCount; i++)
				{
					dividedString[i] = textToDivide.Substring(dividedStringIndex, smallLength);
					dividedStringIndex += smallLength;
				}

				dividedString[partitions - 1] = textToDivide.Substring(dividedStringIndex, bigLength);
			}

			text.RemoveAt(index);
			text.InsertRange(index, dividedString);
		}

		static void Main(string[] args)
		{
			text = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "3:1")
					break;

				string[] inputTokens = input
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				string command = inputTokens[0];
				switch (command)
				{
					case "merge":
						MergePartitions(int.Parse(inputTokens[1]), int.Parse(inputTokens[2]));
						break;
					case "divide":
						DivideToPartitions(int.Parse(inputTokens[1]), int.Parse(inputTokens[2]));
						break;
				}
			}

			Console.WriteLine(string.Join(" ", text));
		}
	}
}