using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();
			long altitude = long.Parse(input[0]);
			bool crashed = false;

			for (long i = 1; i < input.Length; i += 2)
			{
				string direction = input[i];
				long value = long.Parse(input[i + 1]);

				if (direction == "up")
				{
					altitude += value;
				}
				else if (direction == "down")
				{
					altitude -= value;
				}

				if (altitude <= 0)
				{
					crashed = true;
					break;
				}
			}

			if (crashed)
			{
				Console.WriteLine("crashed");
			}
			else
			{
				Console.WriteLine($"got through safely. current altitude: {altitude}m");
			}
		}
	}
}
