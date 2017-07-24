using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			double bpm = double.Parse(Console.ReadLine());
			double numBeats = double.Parse(Console.ReadLine());

			double bars = Math.Round(numBeats / 4, 1);
			double beatsPerSecond = bpm / 60;
			int timeInSeconds = (int) (numBeats / beatsPerSecond);
			int neededMinutes = timeInSeconds / 60;
			int neededSeconds = timeInSeconds % 60;
			Console.WriteLine($"{bars} bars - {neededMinutes}m {neededSeconds}s");

		}
	}
}
