using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
	class Vehicle
	{
		private static Dictionary<string, Vehicle> vehicles =
			new Dictionary<string, Vehicle>();

		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int Horsepower { get; set; }

		public static void AddVehicle(string type, string model, string color, int horsepower)
		{
			Vehicle vehicle = new Vehicle()
			{
				Type = type,
				Model = model,
				Color = color,
				Horsepower = horsepower
			};

			vehicles.Add(model, vehicle);
		}

		public static void GetVehicleInfo(string model)
		{
			Vehicle vehicle = vehicles[model];
			// First letter capitalized
			Console.WriteLine($"Type: {vehicle.Type.First().ToString().ToUpper() + vehicle.Type.Substring(1)}");
			Console.WriteLine($"Model: {vehicle.Model}");
			Console.WriteLine($"Color: {vehicle.Color}");
			Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
		}

		public static decimal AverageHorsepower(string type)
		{
			decimal sumHorsepower = 0;
			int numVehicles = 0;

			foreach (var vehicle in vehicles
				.Where(v => v.Value.Type == type))
			{
				sumHorsepower += vehicle.Value.Horsepower;
				numVehicles++;
			}

			if (numVehicles == 0)
			{
				return 0;
			}
			return sumHorsepower / numVehicles;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "End")
			{
				string[] inputTokens = input.Split();
				string type = inputTokens[0].ToLower();
				string model = inputTokens[1];
				string color = inputTokens[2];
				int horsepower = int.Parse(inputTokens[3]);

				Vehicle.AddVehicle(type, model, color, horsepower);

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			while (input != "Close the Catalogue")
			{
				Vehicle.GetVehicleInfo(input);
				input = Console.ReadLine();
			}

			Console.WriteLine("Cars have average horsepower of: {0:F2}.", Vehicle.AverageHorsepower("car"));
			Console.WriteLine("Trucks have average horsepower of: {0:F2}.", Vehicle.AverageHorsepower("truck"));
		}
	}
}
