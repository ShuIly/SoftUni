using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Rubiks_Matrix
{
	class Program
	{
		static int[][] matrix;

		static void FillMatrix(int col, int row)
		{
			int matrixFiller = 1;
			for (int i = 0; i < col; i++)
			{
				matrix[i] = new int[row];
				for (int j = 0; j < row; j++)
				{
					matrix[i][j] = matrixFiller;
					matrixFiller++;
				}
			}
		}

		static string MatrixSwapper(int col, int row)
		{
			string result = "";

			int currPlace = 0;
			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					currPlace++;

					if (currPlace == matrix[i][j])
					{
						Console.WriteLine("No swap required");
						continue;
					}

					bool foundPlace = false;
					for (int k = 0; k < col && foundPlace == false; k++)
					{
						for (int l = 0; l < row; l++)
						{
							if (matrix[k][l] == currPlace)
							{
								matrix[k][l] = matrix[i][j];
								matrix[i][j] = currPlace;

								Console.WriteLine($"Swap ({i}, {j}) with ({k}, {l})");
								foundPlace = true;
								break;
							}
						}
					}
				}
			}

			return result;
		}

		static void RotateLeft(int col, int count)
		{
			Queue<int> queue = new Queue<int>(matrix[col]);
			count %= queue.Count;

			for (int i = 0; i < count; i++)
				queue.Enqueue(queue.Dequeue());

			matrix[col] = queue.ToArray();
		}

		static void RotateRight(int col, int count)
		{
			Queue<int> queue = new Queue<int>(matrix[col].Reverse());
			count %= queue.Count;

			for (int i = 0; i < count; i++)
				queue.Enqueue(queue.Dequeue());

			matrix[col] = queue.Reverse().ToArray();
		}

		static void RotateUp(int row, int count)
		{
			Queue<int> queue = new Queue<int>();
			count %= matrix.Length;

			for (int i = 0; i < matrix.Length; ++i)
				queue.Enqueue(matrix[i][row]);

			for (int i = 0; i < count; i++)
				queue.Enqueue(queue.Dequeue());

			for (int i = 0; i < matrix.Length; ++i)
				matrix[i][row] = queue.Dequeue();
		}

		static void RotateDown(int row, int count)
		{
			Queue<int> queue = new Queue<int>();
			count %= matrix.Length;

			for (int i = 0; i < matrix.Length; ++i)
				queue.Enqueue(matrix[i][row]);

			queue = new Queue<int>(queue.Reverse());

			for (int i = 0; i < count; i++)
				queue.Enqueue(queue.Dequeue());

			queue = new Queue<int>(queue.Reverse());

			for (int i = 0; i < matrix.Length; ++i)
				matrix[i][row] = queue.Dequeue();
		}

		static void Main(string[] args)
		{
			int[] colRow = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int n = int.Parse(Console.ReadLine());

			matrix = new int[colRow[0]][];
			FillMatrix(colRow[0], colRow[1]);

			for (int i = 0; i < n; i++)
			{
				string[] inputTokens = Console.ReadLine()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				int index = int.Parse(inputTokens[0]);
				int count = int.Parse(inputTokens[2]);

				switch (inputTokens[1])
				{
					case "left":
						RotateLeft(index, count);
						break;
					case "right":
						RotateRight(index, count);
						break;
					case "up":
						RotateUp(index, count);
						break;
					case "down":
						RotateDown(index, count);
						break;
				}
			}

			Console.WriteLine(MatrixSwapper(colRow[0], colRow[1]));
		}
	}
}