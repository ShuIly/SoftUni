using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.Radioactive_Mutant_Vampire_Bunnies
{
	class Program
	{
		static char[][] matrix;
		static int[] playerCoordinates = new int[2];

		static void SetPlayerCoordinates()
		{
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if (matrix[i][j] == 'P')
					{
						playerCoordinates[0] = i;
						playerCoordinates[1] = j;

						return;
					}
				}
			}
		}

		static int PlayerMove(int mvCol, int mvRow)
		{
			// If enemy has multiplied and killed player.
			if (matrix[playerCoordinates[0]][playerCoordinates[1]] == 'B')
				return -2;

			// Player has made a move so we free the space it occupied.
			matrix[playerCoordinates[0]][playerCoordinates[1]] = '.';

			// New player coordinates.
			playerCoordinates[0] += mvCol;
			playerCoordinates[1] += mvRow;

			// If new player coordinates are outside of field, player has won.
			if (playerCoordinates[0] == matrix.Length || playerCoordinates[1] == matrix[0].Length ||
			    playerCoordinates[0] == -1 || playerCoordinates[1] == -1)
			{
			// We revert the player coordinates to the last occupied spot before winning
			// so we can print them on screen.
				playerCoordinates[0] -= mvCol;
				playerCoordinates[1] -= mvRow;
				return 1;
			}

			// If new player coordinates coincide with an enemy, player dies.
			if (matrix[playerCoordinates[0]][playerCoordinates[1]] == 'B')
				return -1;

			matrix[playerCoordinates[0]][playerCoordinates[1]] = 'P';

			// Normal turn if no one won.
			return 0;
		}

		static char[][] MatrixAfterBunnyMove(bool includePlayer)
		{
			char[][] newMatrix = new char[matrix.Length][];

			// Fill new matrix with dots.
			for (int i = 0; i < matrix.Length; i++)
			{
				newMatrix[i] = new char[matrix[i].Length];
				for (int j = 0; j < matrix[i].Length; j++)
					newMatrix[i][j] = '.';
			}

			// True - if player still exists.
			// False - if player won or died.
			if (includePlayer)
				newMatrix[playerCoordinates[0]][playerCoordinates[1]] = 'P';

			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					// We look in the original matrix for enemies and
					// multiply them in the new matrix (We do this in a new matrix
					// so that we don't fill up the whole field from the first move)
					if (matrix[i][j] == 'B')
					{
						newMatrix[i][j] = 'B';
						if (i - 1 >= 0)
							newMatrix[i - 1][j] = 'B';
						if (j - 1 >= 0)
							newMatrix[i][j - 1] = 'B';
						if (i + 1 < matrix.Length)
							newMatrix[i + 1][j] = 'B';
						if (j + 1 < matrix[i].Length)
							newMatrix[i][j + 1] = 'B';
					}
				}
			}

			return newMatrix;
		}

		static void PrintMatrix()
		{
			foreach (var row in matrix)
				Console.WriteLine(string.Join("", row));
		}

		static void Main(string[] args)
		{
			int[] colRow = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			matrix = new char[colRow[0]][];

			for (int i = 0; i < colRow[0]; i++)
				matrix[i] = Console.ReadLine().ToCharArray();

			SetPlayerCoordinates();

			string playerMoves = Console.ReadLine();

			foreach (char move in playerMoves)
			{
				// checkStatus will become 0, 1, -1, -2 based on the
				// results from player's move.
				int checkStatus = 0;
				switch (move)
				{
					case 'U':
						checkStatus = PlayerMove(-1, 0);
						break;
					case 'D':
						checkStatus = PlayerMove(1, 0);
						break;
					case 'L':
						checkStatus = PlayerMove(0, -1);
						break;
					case 'R':
						checkStatus = PlayerMove(0, 1);
						break;
				}

				switch (checkStatus)
				{
					// Normal turn.
					case 0:
						matrix = MatrixAfterBunnyMove(true);
						Console.WriteLine();
						break;
					// If player wins.
					case 1:
						matrix = MatrixAfterBunnyMove(false);
						PrintMatrix();
						Console.WriteLine($"won: {playerCoordinates[0]} {playerCoordinates[1]}");
						return;
					// If player goes TO the enemy, enemy has to multiply
					// one more time before we print on the screen.
					case -1:
						matrix = MatrixAfterBunnyMove(false);
						PrintMatrix();
						Console.WriteLine($"dead: {playerCoordinates[0]} {playerCoordinates[1]}");
						return;
					// If enemy multiplies and kills player, we don't have
					// to multiply it again.
					case -2:
						PrintMatrix();
						Console.WriteLine($"dead: {playerCoordinates[0]} {playerCoordinates[1]}");
						return;
				}
			}
		}
	}
}