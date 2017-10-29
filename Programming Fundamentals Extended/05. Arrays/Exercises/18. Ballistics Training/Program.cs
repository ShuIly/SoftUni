using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Ballistics_Training
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] coordinates = Console.ReadLine().Split();
			string[] commands = Console.ReadLine().Split();
			long targetX = long.Parse(coordinates[0]);
			long targetY = long.Parse(coordinates[1]);
			long currX = 0;
			long currY = 0;

			for (long i = 0; i < commands.Length; i += 2)
			{
				string direction = commands[i];
				long value = 0;

				switch (direction)
				{
					// we parse value only after we've confirmed that command is legit
					// otherwise we get runtime exeption in Judge.
					case "up":
						value = long.Parse(commands[i + 1]);
						currY += value;
						break;
					case "down":
						value = long.Parse(commands[i + 1]);
						currY -= value;
						break;
					case "right":
						value = long.Parse(commands[i + 1]);
						currX += value;
						break;
					case "left":
						value = long.Parse(commands[i + 1]);
						currX -= value;
						break;
				}
			}

			Console.WriteLine($"firing at [{currX}, {currY}]");

			if (currX == targetX && currY == targetY)
			{
				Console.WriteLine("got 'em!");
			}
			else
			{
				Console.WriteLine("better luck next time...");
			}
		}
	}
}
