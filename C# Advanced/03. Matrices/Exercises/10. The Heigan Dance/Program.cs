using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace _10.The_Heigan_Dance
{
	class Player
	{
		public int Health { get; set; }
		public int Damage { get; set; }
		public int RowIndex { get; set; }
		public int ColIndex { get; set; }

		public Player(int damage)
		{
			Health = 18500;
			Damage = damage;
			RowIndex = 7;
			ColIndex = 7;
		}

		public bool Dodge(int[][] matrix)
		{
			if (matrix[RowIndex - 1][ColIndex] == 0)
			{
				RowIndex--;
				return true;
			}

			if (matrix[RowIndex + 1][ColIndex] == 0)
			{
				RowIndex++;
				return true;
			}

			if (matrix[RowIndex][ColIndex - 1] == 0)
			{
				ColIndex--;
				return true;
			}

			if (matrix[RowIndex][ColIndex + 1] == 0)
			{
				ColIndex++;
				return true;
			}

			return false;
		}

		public void TakeDamage(int attack)
		{
			Health -= attack;
		}
	}

	class Heigan
	{
		public int Health { get; set; }

		public static Dictionary<string, int> SpellDamage = new Dictionary<string, int>()
			{
				{ "Eruption", 6000 },
				{ "Cloud", 3500 }
			};

		public Heigan()
		{
			Health = 3000000;
		}

		public void TakeDamage(int attack)
		{
			Health -= attack;
		}

		public void CastSpell(int[][] matrix, int row, int col, string spellType)
		{
			int top = row - 1;
			int bottom = row + 1;
			int left = col - 1;
			int right = col + 1;

			int duration = spellType == "Eruption" ? 1 : 2;

			for (int i = top; i <= bottom; i++)
			{
				for (int j = left; j <= right; j++)
				{
					if (i >= 0 && i < matrix.Length && j >= 0 && j < matrix[i].Length)
						matrix[i][j] = duration;
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			int[][] matrix = new int[15][];
			for (int i = 0; i < 15; i++)
			{
				matrix[i] = new int[15];
			}

			Player player = new Player(int.Parse(Console.ReadLine()));
			Heigan heigan = new Heigan();

			while (heigan.Health > 0 && player.Health > 0)
			{
				string[] inputArgs = Console.ReadLine()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string spell = inputArgs[0];
				int row = int.Parse(inputArgs[1]);
				int col = int.Parse(inputArgs[2]);

				heigan.CastSpell(matrix, row, col, spell);
				if (!player.Dodge(matrix))
					player.TakeDamage(heigan);
			}
		}
	}
}