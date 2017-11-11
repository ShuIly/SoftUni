using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _10.The_Heigan_Dance
{
	/*
	 * Okay whoever made this exercise deserves to die. 90/100.
	 */
	class Status
	{
		public string Name { get; set; }
		public int Damage { get; set; }
		public int Duration { get; set; }

		public Status(string name, int damage, int duration)
		{
			Name = name;
			Damage = damage;
			Duration = duration;
		}
	}

	class Cell
	{
		public Dictionary<string, List<Status>> Statuses { get; set; }

		public Cell()
		{
			Statuses = new Dictionary<string, List<Status>>();
		}

		public int GetSumStatusDamage()
		{
			int sumDamage = 0;
			foreach (var statusList in Statuses.Values)
			{
				foreach (var status in statusList)
				{
					sumDamage += status.Damage;
				}
			}

			return sumDamage;
		}

		public void DrainStatus()
		{
			Queue<string> statusForRemoval = new Queue<string>();
			foreach (var statusDict in Statuses)
			{
				List<Status> statusList = statusDict.Value;
				for (int i = statusList.Count - 1; i >= 0; --i)
				{
					statusList[i].Duration--;

					if (statusList[i].Duration == 0)
						Statuses[statusDict.Key].RemoveAt(i);
				}

				if (statusList.Count == 0)
					statusForRemoval.Enqueue(statusDict.Key);
			}

			while (statusForRemoval.Count > 0)
				Statuses.Remove(statusForRemoval.Dequeue());
		}
	}

	class Player
	{
		public int Health { get; set; }
		public double Damage { get; set; }
		public int RowIndex { get; set; }
		public int ColIndex { get; set; }
		public string DeathReason { get; set; }

		public Player(double damage)
		{
			Health = 18500;
			Damage = damage;
			RowIndex = 7;
			ColIndex = 7;
			DeathReason = "None";
		}

		public bool IsAlive()
		{
			if (Health > 0)
				return true;

			return false;
		}

		public bool Dodge(Cell[][] matrix)
		{
			int sumDamage = matrix[RowIndex][ColIndex].GetSumStatusDamage();
			int bestRow = RowIndex;
			int bestCol = ColIndex;

			if (RowIndex - 1 >= 0 && RowIndex - 1 < 15 && ColIndex >= 0 && ColIndex < 15)
			{
				if (matrix[RowIndex - 1][ColIndex].Statuses.Count == 0)
				{
					RowIndex--;
					return true;
				}

				if (matrix[RowIndex - 1][ColIndex].GetSumStatusDamage() < sumDamage)
				{

					bestRow = RowIndex - 1;
					bestCol = ColIndex;
				}
			}

			if (RowIndex >= 0 && RowIndex < 15 && ColIndex + 1 >= 0 && ColIndex + 1 < 15)
			{
				if (matrix[RowIndex][ColIndex + 1].Statuses.Count == 0)
				{
					ColIndex++;
					return true;
				}

				if (matrix[RowIndex][ColIndex + 1].GetSumStatusDamage() < sumDamage)
				{
					bestRow = RowIndex;
					bestCol = ColIndex + 1;
				}
			}

			if (RowIndex + 1 >= 0 && RowIndex + 1 < 15 && ColIndex >= 0 && ColIndex < 15)
			{
				if (matrix[RowIndex + 1][ColIndex].Statuses.Count == 0)
				{
					RowIndex++;
					return true;
				}

				if (matrix[RowIndex + 1][ColIndex].GetSumStatusDamage() < sumDamage)
				{
					bestRow = RowIndex + 1;
					bestCol = ColIndex;
				}
			}

			if (RowIndex >= 0 && RowIndex < 15 && ColIndex - 1 >= 0 && ColIndex - 1 < 15)
			{
				if (matrix[RowIndex][ColIndex - 1].Statuses.Count == 0)
				{
					ColIndex--;
					return true;
				}

				if (matrix[RowIndex][ColIndex - 1].GetSumStatusDamage() < sumDamage)
				{
					bestRow = RowIndex;
					bestCol = ColIndex - 1;
				}
			}

			RowIndex = bestRow;
			ColIndex = bestCol;

			foreach (var statusList in matrix[RowIndex][ColIndex].Statuses.Values)
			{
				foreach (var status in statusList)
				{
					Health -= status.Damage;
					if (!IsAlive())
					{
						DeathReason = status.Name;

						if (DeathReason == "Cloud")
							DeathReason = "Plague Cloud";

						return false;
					}
				}
			}

			return false;
		}
	}

	class Heigan
	{
		public double Health { get; set; }

		public Heigan()
		{
			Health = 3000000;
		}

		public void CastSpell(Cell[][] matrix, int row, int col, string spellType)
		{
			int top = row - 1;
			int bottom = row + 1;
			int left = col - 1;
			int right = col + 1;

			// A hack, I know, but I don't want to create a new class called Spells...
			int duration = spellType == "Eruption" ? 1 : 2;
			int damage = spellType == "Eruption" ? 6000 : 3500;

			for (int i = top; i <= bottom; i++)
			{
				for (int j = left; j <= right; j++)
				{
					if (i >= 0 && i < matrix.Length && j >= 0 && j < matrix[i].Length)
					{
						if (!matrix[i][j].Statuses.ContainsKey(spellType))
							matrix[i][j].Statuses.Add(spellType, new List<Status>());

						matrix[i][j].Statuses[spellType].Add(new Status(spellType, damage, duration));
					}
				}
			}
		}

		public bool IsAlive()
		{
			if (Health > 0)
				return true;

			return false;
		}
	}

	class Program
	{
		static void PrintMartix(Cell[][] matrix, Player player)
		{
			string result = "";
			for (int i = 0; i < 15; i++)
			{
				for (int j = 0; j < 15; j++)
				{
					if (matrix[i][j].Statuses.ContainsKey("Eruption"))
						result += "E";

					if (matrix[i][j].Statuses.ContainsKey("Cloud"))
						result += "C";

					if (i == player.RowIndex && j == player.ColIndex)
						result += "P";
					else if (matrix[i][j].Statuses.Count == 0)
						result += ".";

					result += " ";
				}

				result += Environment.NewLine;
			}

			Console.WriteLine(result);
		}

		static void Main(string[] args)
		{
			Cell[][] matrix = new Cell[15][];
			for (int i = 0; i < 15; i++)
			{
				matrix[i] = new Cell[15];
				for (int j = 0; j < 15; j++)
				{
					matrix[i][j] = new Cell();
				}
			}

			Player player = new Player(double.Parse(Console.ReadLine()));
			Heigan heigan = new Heigan();

			string result = "";
			while (heigan.Health > 0 && player.Health > 0)
			{
				string[] inputArgs = Console.ReadLine()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				string spell = inputArgs[0];
				int row = int.Parse(inputArgs[1]);
				int col = int.Parse(inputArgs[2]);

				heigan.Health -= player.Damage;

				if (heigan.IsAlive())
					heigan.CastSpell(matrix, row, col, spell);

				if (matrix[player.RowIndex][player.ColIndex].Statuses.Count > 0)
					player.Dodge(matrix);

				if (!player.IsAlive() || !heigan.IsAlive())
					break;

				PrintMartix(matrix, player);

				for (int i = 0; i < 15; i++)
				{
					for (int j = 0; j < 15; j++)
					{
						matrix[i][j].DrainStatus();
					}
				}
			}

			if (!heigan.IsAlive() && !player.IsAlive())
				result += "Heigan: Defeated!\n" +
						  $"Player: Killed by {player.DeathReason}\n";

			if (heigan.IsAlive() && !player.IsAlive())
				result += $"Heigan: {heigan.Health:F2}\n" +
						  $"Player: Killed by {player.DeathReason}\n";

			if (!heigan.IsAlive() && player.IsAlive())
				result += "Heigan: Defeated!\n" +
						  $"Player: {player.Health}\n";

			result += $"Final position: {player.RowIndex}, {player.ColIndex}";
			PrintMartix(matrix, player);

			Console.WriteLine(result);
		}
	}
}