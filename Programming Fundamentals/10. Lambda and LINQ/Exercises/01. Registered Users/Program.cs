using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Registered_Users
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, DateTime> registeredUsers = new Dictionary<string, DateTime>();
			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] inputInfo = command
					.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				string username = inputInfo[0];
				DateTime registerDate = DateTime.ParseExact(inputInfo[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

				if (!registeredUsers.ContainsKey(username))
				{
					registeredUsers.Add(username, registerDate);
				}
				else
				{
					Console.WriteLine("Someone with that username already registered!");
				}

				command = Console.ReadLine();
			}

			foreach (KeyValuePair<string, DateTime> user in registeredUsers
				// If there are people with same registry dates, we need the last one first
				.Reverse() 
				.OrderBy(x => x.Value)
				.Take(5)
				.OrderByDescending(x => x.Value))
			{
				Console.WriteLine(user.Key);
			}
		}
	}
}
