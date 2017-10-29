using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _02.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
	        var reservatedSeats = new HashSet<string>();

	        while (true)
	        {
		        string input = Console.ReadLine();
		        if (input == "PARTY")
					break;

		        reservatedSeats.Add(input);
	        }

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "END")
					break;

				reservatedSeats.Remove(input);
			}

	        Console.WriteLine(reservatedSeats.Count + "\n" +
				string.Join(Environment.NewLine, reservatedSeats
				.OrderBy(s => s)));
        }
    }
}