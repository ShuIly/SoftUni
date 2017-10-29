using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
	        var parkedCars = new HashSet<string>();
	        while (true)
	        {
		        string input = Console.ReadLine();

		        if (input == "END")
					break;

		        string[] inputTokens = input
			        .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

		        string direction = inputTokens[0];
		        string carID = inputTokens[1];

		        switch (direction)
		        {
					case "IN":
						parkedCars.Add(carID);
						break;
					case "OUT":
						parkedCars.Remove(carID);
						break;
		        }
	        }

			if (parkedCars.Count > 0)
			{
				Console.WriteLine(string.Join(Environment.NewLine, parkedCars
					.OrderBy(c => c)));
			}
			else
				Console.WriteLine("Parking Lot is Empty");
        }
    }
}