using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Command_Interpreter
{
	class Program
	{
		static string[] arr;

		static bool CheckParameters(int startIndex, int count)
		{
			if (startIndex < 0 || startIndex >= arr.Length || count < 0 || startIndex + count > arr.Length)
			{
				Console.WriteLine("Invalid input parameters.");
				return false;
			}

			return true;
		}

		static bool CheckParameters(int count)
		{
			if (count < 0)
			{
				Console.WriteLine("Invalid input parameters.");
				return false;
			}

			return true;
		}

		static void ReverseList(int startIndex, int count)
		{
			if (!CheckParameters(startIndex, count))
				return;

			string[] reversedArr = arr
				.Skip(startIndex)
				.Take(count)
				.Reverse()
				.ToArray();

			for (int i = 0; i < count; i++)
				arr[i + startIndex] = reversedArr[i];
		}

		static void Sort(int startIndex, int count)
		{
			if (!CheckParameters(startIndex, count))
				return;

			string[] sortedArr = arr
				.Skip(startIndex)
				.Take(count)
				.OrderBy(s => s)
				.ToArray();

			for (int i = 0; i < count; i++)
				arr[i + startIndex] = sortedArr[i];
		}

		static void RollLeft(int count)
		{
			if (!CheckParameters(count))
				return;

			Queue<string> queue = new Queue<string>(arr);
			for (int i = 0; i < count % arr.Length; i++)
				queue.Enqueue(queue.Dequeue());

			arr = queue.ToArray();
		}

		static void RollRight(int count)
		{
			if (!CheckParameters(count))
				return;

			Queue<string> queue = new Queue<string>(arr.Reverse());

			for (int i = 0; i < count % arr.Length; i++)
				queue.Enqueue(queue.Dequeue());

			arr = queue.Reverse().ToArray();
		}

		static void Main(string[] args)
		{
			arr = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "end")
					break;

				string[] inputTokens = input
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string command = inputTokens[0];

				switch (command)
				{
					case "reverse":
						ReverseList(int.Parse(inputTokens[2]), int.Parse(inputTokens[4]));
						break;
					case "rollLeft":
						RollLeft(int.Parse(inputTokens[1]));
						break;
					case "rollRight":
						RollRight(int.Parse(inputTokens[1]));
						break;
					case "sort":
						Sort(int.Parse(inputTokens[2]), int.Parse(inputTokens[4]));
						break;
				}
			}

			Console.WriteLine($"[{string.Join(", ", arr)}]");
		}
	}
}