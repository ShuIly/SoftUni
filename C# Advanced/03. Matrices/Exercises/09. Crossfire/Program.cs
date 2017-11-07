using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _09.Crossfire
{
	class Program
	{
		static int[][] matrix;

		static void FillMatrix(int[] rowCol)
		{
			matrix = new int[rowCol[0]][];

			int incrementer = 1;
			for (int i = 0; i < rowCol[0]; i++)
			{
				matrix[i] = new int[rowCol[1]];
				for (int j = 0; j < rowCol[1]; j++)
				{
					matrix[i][j] = incrementer;
					incrementer++;
				}
			}
		}

		static void NukeMatrix(int[] nukeParams)
		{
			int row = nukeParams[0];
			int col = nukeParams[1];
			int blastRadius = nukeParams[2];

			if ((row < 0 || row >= matrix.Length) &&
				(col < 0 || col >= matrix[0].Length))
				return;

			if (row < 0)
			{
				int bottom = blastRadius + row;
				if (bottom < 0)
					return;

				if (bottom >= matrix.Length)
					bottom = matrix.Length - 1;

				for (int i = 0; i <= bottom; i++)
				{
					if (matrix[i][col] == 0 && bottom != matrix.Length - 1 && matrix[i].All(n => n == 0))
						bottom++;
					matrix[i][col] = 0;
				}

				return;
			}

			if (row >= matrix.Length)
			{
				int top = row - blastRadius;
				if (top >= matrix.Length)
					return;

				if (top < 0)
					top = 0;

				for (int i = matrix.Length - 1; i >= top; i--)
				{
					if (matrix[i][col] == 0 && top != 0 && matrix[i].All(n => n == 0))
						top--;
					matrix[i][col] = 0;
				}

				return;
			}

			if (col < 0)
			{
				int right = blastRadius + col;
				if (right < 0)
					return;

				if (right >= matrix[0].Length)
					right = matrix[0].Length - 1;

				for (int i = 0; i <= right; i++)
					matrix[row][i] = 0;

				return;
			}

			if (col >= matrix[0].Length)
			{
				int left = col - blastRadius;
				if (left >= matrix[0].Length)
					return;

				if (left < 0)
					left = 0;

				for (int i = matrix[0].Length - 1; i >= left; i--)
					matrix[row][i] = 0;

				return;
			}

			matrix[row][col] = 0;

			int bottomIndex = blastRadius + row;
			if (bottomIndex >= matrix.Length)
				bottomIndex = matrix.Length - 1;

			for (int i = row + 1; i <= bottomIndex; i++)
			{
				if (matrix[i][col] == 0 && bottomIndex != matrix.Length - 1 && matrix[i].All(n => n == 0))
					bottomIndex++;
				matrix[i][col] = 0;
			}

			int topIndex = row - blastRadius;
			if (topIndex < 0)
				topIndex = 0;

			for (int i = row - 1; i >= topIndex; i--)
			{
				if (matrix[i][col] == 0 && topIndex != 0 && matrix[i].All(n => n == 0))
					topIndex--;
				matrix[i][col] = 0;
			}

			int leftIndex = col - blastRadius;
			if (leftIndex < 0)
				leftIndex = 0;

			for (int i = col - 1; i >= leftIndex; i--)
				matrix[row][i] = 0;

			int rightIndex = blastRadius + col;
			if (rightIndex >= matrix[0].Length)
				rightIndex = matrix[0].Length - 1;

			for (int i = col + 1; i <= rightIndex; i++)
				matrix[row][i] = 0;
		}

		static int[][] GetCollapsedMatrix()
		{
			int[][] newMatrix = new int[matrix.Length][];
			for (int i = 0; i < matrix.Length; i++)
			{
				newMatrix[i] = new int[matrix[0].Length];
				int collapsedCol = 0;
				for (int j = 0; j < matrix[0].Length; j++)
				{
					if (matrix[i][j] != 0)
					{
						newMatrix[i][collapsedCol] = matrix[i][j];
						collapsedCol++;
					}
				}
			}

			return newMatrix;
		}

		static void Main(string[] args)
		{
			int[] rowCol = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			FillMatrix(rowCol);

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "Nuke it from orbit")
					break;

				int[] nukeParams = input
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				NukeMatrix(nukeParams);
				matrix = GetCollapsedMatrix();
			}

			foreach (var row in matrix.Where(e => e.Any(n => n != 0)))
				Console.WriteLine(string.Join(" ", row.Where(n => n > 0)));
		}
	}
}