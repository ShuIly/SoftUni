using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel_Company
{
	class Program
	{
		static void Main(string[] args)
		{
			var countryTransports = new SortedDictionary<string, Dictionary<string, int>>();

			// Athens:bus-40,airplane-300,train-150
			string transportInfo = Console.ReadLine();

			while (transportInfo != "ready")
			{
				// {Athens}{bus-40,airplane-300,train-150}
				string[] transportInfoSections = transportInfo.Split(':');

				// {bus-40}{airplane-300}{train-150}
				string[] transportNameCapacities = transportInfoSections[1].Split(',');

				// Athens
				string countryName = transportInfoSections[0];

				if (!countryTransports.ContainsKey(countryName))
				{
					countryTransports.Add(countryName, new Dictionary<string, int>());
				}

				int transportCount = transportNameCapacities.Length;
				for (int i = 0; i < transportCount; i++)
				{
					// i = 0 -> {bus}{40};  i = 1 -> {airplane}{300}; ...
					string[] currTransportNameCapacity = transportNameCapacities[i].Split('-');

					// i = 0 -> bus;  i = 1 -> airplane;
					string currTransportName = currTransportNameCapacity[0];

					// i = 0 -> 40;  i = 1 -> 300;
					int currTransportCapacity = int.Parse(currTransportNameCapacity[1]);

					countryTransports[countryName][currTransportName] = currTransportCapacity;
				}
				transportInfo = Console.ReadLine();
			}

			string passengersInfo = Console.ReadLine();
			while (passengersInfo != "travel time!")
			{
				string[] passengerInfoSections = passengersInfo.Split();
				string passengerDestination = passengerInfoSections[0];
				int passengerQuantity = int.Parse(passengerInfoSections[1]);

				int countryTransportCapacity = 0;
				foreach (KeyValuePair<string, int> vehicleCapacity in countryTransports[passengerDestination])
				{
					countryTransportCapacity += vehicleCapacity.Value;
				}

				if (countryTransportCapacity >= passengerQuantity)
				{
					Console.WriteLine("{0} -> all {1} accommodated", passengerDestination, passengerQuantity);
				}
				else
				{
					int passengersLeft = passengerQuantity - countryTransportCapacity;
					Console.WriteLine("{0} -> all except {1} accommodated", passengerDestination, passengersLeft);
				}

				passengersInfo = Console.ReadLine();
			}
		}
	}
}
