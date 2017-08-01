using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] str = Console.ReadLine().Split();
			int energy = int.Parse(Console.ReadLine());
			int strCount = str.Length;

			for (int i = 0; i < strCount; i++)
			{
				if (str[i] == "RabbitHole")
				{
					Console.WriteLine("You have 5 years to save Kennedy!");
					break;
				}

				string[] command = str[i].Split('|');

				string direction = command[0];
				int value = int.Parse(command[1]);

				if (direction == "Left")
				{
					i -= value;
					energy -= value;
				}
				else if (direction == "Right")
				{
					energy -= value;
					if (value + i >= strCount)
					{
						while (value + i >= strCount)
						{
							value -= strCount;
						}

						i = value;
					}
					else
					{
						i += value;
					}
				}
				else if (direction == "Bomb")
				{
					// -1 because it gets immediately incremented
					i = -1;
					energy -= value;
				}

				if (energy <= 0)
				{
					Console.WriteLine("You are tired. You can't continue the mission.");
					break;
				}
			}
		}
	}
}
