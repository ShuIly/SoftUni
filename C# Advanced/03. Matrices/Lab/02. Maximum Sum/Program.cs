using System;
using System.Linq;

namespace _02.Maximum_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] colRow = Console.ReadLine()
				.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int col = colRow[0];

			int[][] matrix = new int[col][];
			for (int i = 0; i < col; i++)
			{
				matrix[i] = Console.ReadLine()
					.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
			}

			int topLeft = 0;
			int topRight = 0;
			int bottomLeft = 0;
			int bottomRight = 0;

			int maxSum = int.MinValue;
			for (int i = 1; i < matrix.Length; i++)
			{
				for (int j = 1; j < matrix[i].Length; j++)
				{
					int currSum = matrix[i - 1][j - 1] + matrix[i][j - 1] +
					              matrix[i - 1][j] + matrix[i][j];
					if (currSum > maxSum)
					{
						topLeft = matrix[i - 1][j - 1];
						topRight = matrix[i - 1][j];
						bottomLeft = matrix[i][j - 1];
						bottomRight = matrix[i][j];

						maxSum = currSum;
					} 
				}
			}

			string result = $"{topLeft} {topRight}\n{bottomLeft} {bottomRight}\n{maxSum}\n";
			Console.WriteLine(result);
		}
	}
}