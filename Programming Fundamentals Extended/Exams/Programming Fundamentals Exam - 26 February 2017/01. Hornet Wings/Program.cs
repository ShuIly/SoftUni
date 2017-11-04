using System;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
	        int wingflaps = int.Parse(Console.ReadLine());
	        double distForThousandWingflaps = double.Parse(Console.ReadLine());
	        int endurance = int.Parse(Console.ReadLine());

	        double wingflapDist = distForThousandWingflaps / 1000;
	        int breakCount = wingflaps / endurance;

	        double secondsPassed = wingflaps * 0.01 + breakCount * 5;
	        double metersTravelled = wingflaps * wingflapDist;

	        Console.WriteLine($"{metersTravelled:F2} m.\n{secondsPassed} s.");
        }
    }
}