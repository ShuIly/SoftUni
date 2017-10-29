using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Play_Catch
{
	class Program
	{
		static int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
		static int exceptionCount = 0;

		static void PrintArrInRange(string start, string end)
		{
			try
			{
				int startIndex = int.Parse(start);
				int endIndex = int.Parse(end);
				int startIndexCheck = arr[startIndex];
				int endIndexCheck = arr[endIndex];

				// In case start index is bigger than end index
				if (startIndex > endIndex)
				{
					int temp = startIndex;
					startIndex = endIndex;
					endIndex = temp;
				}

				Console.Write($"{arr[startIndex]}");
				for (int i = startIndex + 1; i <= endIndex; i++)
				{
					Console.Write($", {arr[i]}");
				}

				Console.WriteLine();
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("The index does not exist!");
				exceptionCount++;
			}
			catch (FormatException)
			{
				Console.WriteLine("The variable is not in the correct format!");
				exceptionCount++;
			}
		}

		public static void Replace(string index, string replaceVal)
		{
			try
			{
				int indexCheck = int.Parse(index);
				int checkOutOfRange = arr[indexCheck];
				int checkReplaceVal = int.Parse(replaceVal);
				arr[indexCheck] = checkReplaceVal;
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("The index does not exist!");
				exceptionCount++;
			}
			catch (FormatException)
			{
				Console.WriteLine("The variable is not in the correct format!");
				exceptionCount++;
			}
		}

		public static void Show(string index)
		{
			try
			{
				int indexCheck = int.Parse(index);
				int checkOutOfRange = arr[indexCheck];
				Console.WriteLine(arr[indexCheck]);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("The index does not exist!");
				exceptionCount++;
			}
			catch (FormatException)
			{
				Console.WriteLine("The variable is not in the correct format!");
				exceptionCount++;
			}
		}

		static void Main()
		{
			while (exceptionCount < 3)
			{
				string[] inputTokens = Console.ReadLine().Split();
				switch (inputTokens[0])
				{
					case "Replace":
						Replace(inputTokens[1], inputTokens[2]);
						break;
					case "Print":
						PrintArrInRange(inputTokens[1], inputTokens[2]);
						break;
					case "Show":
						Show(inputTokens[1]);
						break;
				}
			}

			Console.WriteLine(string.Join(", ", arr));
		}
	}
}
