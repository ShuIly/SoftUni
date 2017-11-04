using System;
using System.Linq;

namespace _06.Target_Practice
{
	class Program
	{
		/*
		 * Okay so I am really fucking pissed at the author for not fucking 
		 * explaining how the shot area will really look like. Wasted 2
		 * fucking days looking for a problem that I didn't have. Just the
		 * fucking shot radius should look different.
		 *
		 */
		static char[][] matrix;
		static void FillMatrix(int col, int row, string snake)
		{
			bool left = true;
			int snakeIndex = 0;

			for (int i = col - 1; i >= 0; i--)
			{
				matrix[i] = new char[row];

				if (left)
				{
					for (int j = row - 1; j >= 0; j--)
					{
						if (snakeIndex == snake.Length)
							snakeIndex = 0;

						matrix[i][j] = snake[snakeIndex];
						snakeIndex++;
					}

					left = false;
				}
				else
				{
					for (int j = 0; j < row; j++)
					{
						if (snakeIndex == snake.Length)
							snakeIndex = 0;

						matrix[i][j] = snake[snakeIndex];
						snakeIndex++;
					}

					left = true;
				}
			}
		}


		static void ShootMatrix(int[] blastInfo)
		{
			// startPoint = verticalPosition - blastRadius
			int colStartPoint = blastInfo[0] - blastInfo[2];
			if (colStartPoint < 0)
				colStartPoint = 0;

			int incrementer = blastInfo[2] - (blastInfo[0] - colStartPoint);
			for (int i = colStartPoint; i <= blastInfo[0]; i++)
			{
				int radiusStart = blastInfo[1] - incrementer;
				int radiusEnd = blastInfo[1] + incrementer;

				if (radiusStart < 0)
					radiusStart = 0;

				if (radiusEnd >= matrix[i].Length)
					radiusEnd = matrix[i].Length - 1;

				for (int j = radiusStart; j <= radiusEnd; j++)
					matrix[i][j] = ' ';

				incrementer++;
			}

			colStartPoint = blastInfo[0] + 1;
			if (colStartPoint == matrix.Length)
				return;

			incrementer -= 2;

			int colEndPoint = blastInfo[0] + blastInfo[2];
			if (colEndPoint >= matrix.Length)
				colEndPoint = matrix.Length - 1;

			for (int i = colStartPoint; i <= colEndPoint; i++)
			{
				int radiusStart = blastInfo[1] - incrementer;
				int radiusEnd = blastInfo[1] + incrementer;

				if (radiusStart < 0)
					radiusStart = 0;

				if (radiusEnd >= matrix[i].Length)
					radiusEnd = matrix[i].Length - 1;

				for (int j = radiusStart; j <= radiusEnd; j++)
					matrix[i][j] = ' ';

				incrementer--;
			}
		}

		static void CollapseMatrix(int[] blastInfo)
		{
			int leftmostPoint = blastInfo[1] - blastInfo[2];
			if (leftmostPoint < 0)
				leftmostPoint = 0;

			int highestPoint = blastInfo[0] - blastInfo[2];
			if (highestPoint < 0)
				highestPoint = 0;

			int rightmostPoint = blastInfo[1] + blastInfo[2];
			if (rightmostPoint >= matrix[0].Length)
				rightmostPoint = matrix[0].Length - 1;

			for (int i = highestPoint; i <= blastInfo[0]; i++)
			{
				for (int j = leftmostPoint; j <= rightmostPoint; j++)
				{
					if (matrix[i][j] == ' ')
					{
						// A super complex formula to calculate the vertical index of the space of the bottom.
						int lowestSpaceIndex = blastInfo[0] + blastInfo[2] - Math.Abs(blastInfo[1] - j);
						if (lowestSpaceIndex >= matrix.Length)
							lowestSpaceIndex = matrix.Length - 1;

						for (int k = i - 1; k >= 0; k--)
						{
							if (matrix[k][j] != ' ')
							{
								matrix[lowestSpaceIndex][j] = matrix[k][j];
								matrix[k][j] = ' ';

								// We filled space at bottom so it goes one position up.
								lowestSpaceIndex--;
							}
						}
					}
				}
			}
		}

		static void Main(string[] args)
		{
			int[] colRow = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			string snake = Console.ReadLine();
			int[] blastInfo = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			matrix = new char[colRow[0]][];

			FillMatrix(colRow[0], colRow[1], snake);
			ShootMatrix(blastInfo);
			CollapseMatrix(blastInfo);

			foreach (var row in matrix)
				Console.WriteLine(string.Join("", row));
		}
	}
}