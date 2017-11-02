using System;
using System.Linq;

namespace _04.Maximal_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] colRow = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[][] matrix = new int[colRow[0]][];

			for (int i = 0; i < matrix.Length; i++)
			{
				matrix[i] = Console.ReadLine()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
			}

			int[][] bestSumMatrix = new int[3][];
			int col = colRow[0] - 2;
			int row = colRow[1] - 2;

			int maxSum = int.MinValue;
			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					int currSum = 0;
					int[][] currSumMatrix = new int[3][];

					for (int k = 0; k < 3; k++)
					{
						currSumMatrix[k] = new int[3];
						for (int l = 0; l < 3; l++)
						{
							currSumMatrix[k][l] = matrix[i + k][j + l];
							currSum += currSumMatrix[k][l];
						}

						if (currSum > maxSum)
						{
							bestSumMatrix = currSumMatrix;
							maxSum = currSum;
						}
					}
				}
			}

			string result = $"Sum = {maxSum}\n";
			foreach (int[] r in bestSumMatrix)
				result += string.Join(" ", r) + "\n";

			Console.WriteLine(result);
		}
	}
}