using System;

namespace _01.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
	        int pokePower = int.Parse(Console.ReadLine());
	        int distance = int.Parse(Console.ReadLine());
	        int exhaustionFactor = int.Parse(Console.ReadLine());

	        int pokes = 0;
	        int currPower = pokePower;
	        int halfPower = pokePower / 2;

	        while (true)
	        {
		        if (currPower == halfPower && exhaustionFactor > 0)
			        currPower /= exhaustionFactor;

		        if (currPower >= distance)
		        {
					currPower -= distance;
					pokes++;
		        }
				else
					break;
	        }

	        Console.WriteLine(currPower);
	        Console.WriteLine(pokes);
        }
    }
}