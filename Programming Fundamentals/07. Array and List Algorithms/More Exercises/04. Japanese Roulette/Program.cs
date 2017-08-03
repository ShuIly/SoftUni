using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Japanese_Roulette
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] cylinder = Console.ReadLine().Split().Select(int.Parse).ToArray();
			string[] moves = Console.ReadLine().Split();

			int cylinderHoles = cylinder.Length;
			int muzzlePos = 2;
			int movesCount = moves.Length;
			int bulletPos = GetBulletPos(cylinder);
			bool alive = true;

			for (int i = 0; i < movesCount; i++)
			{
				int value = int.Parse(moves[i].Split(',')[0]);
				string direction = moves[i].Split(',')[1];

				if (direction == "Left")
				{
					muzzlePos = (muzzlePos + value) % cylinderHoles;
				}
				else
				{
					muzzlePos = (muzzlePos - value) % cylinderHoles;
					if (muzzlePos < 0)
					{
						muzzlePos += cylinderHoles; 
					}
				}

				if (muzzlePos == bulletPos)
				{
					Console.WriteLine("Game over! Player {0} is dead.", i);
					alive = false;
					break;
				}

				muzzlePos--;
			}
			if (alive)
			{
				Console.WriteLine("Everybody got lucky!");
			}
		}

		static int GetBulletPos(int[] cylinder)
		{
			int cylinderHoles = cylinder.Length;
			for (int i = 0; i < cylinderHoles; i++)
			{
				if (cylinder[i] == 1)
				{
					return i;
				}
			}

			return -1;
		}
	}
}
