using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.User_Database
{
	class User
	{
		private static Dictionary<string, User> users =
			new Dictionary<string, User>();
		public string Name { get; set; }
		public string Password { get; set; }
		public bool LoggedIn { get; set; }

		public User(string name, string password)
		{
			Name = name;
			Password = password;
			LoggedIn = false;
		}

		public static void RegisterUser(string username, string password, string confirmPassword)
		{
			if (users.ContainsKey(username))
			{
				Console.WriteLine("The given username already exists.");
			}
			else if (password != confirmPassword)
			{
				Console.WriteLine("The two passwords must match.");
			}
			else
			{
				users.Add(username, new User(username, password));
			}
		}

		public static void Login(string name, string password)
		{
			if (users.ContainsKey(name))
			{
				if (users[name].Password == password)
				{
					if (users[name].LoggedIn == false)
					{
						users[name].LoggedIn = true;
					}
					else
					{
						Console.WriteLine("Someone's already logged in with that username.");
					}
				}
				else
				{
					Console.WriteLine("The password you entered is incorrect.");
				}
			}
			else
			{
				Console.WriteLine("There is no user with the given username.");
			}
		}

		public static void Logout()
		{
			bool someoneLogged = false;
			foreach (var user in users)
			{
				if (user.Value.LoggedIn == true)
				{
					someoneLogged = true;
					user.Value.LoggedIn = false;
				}
			}

			if (!someoneLogged)
			{
				Console.WriteLine("There is no currently logged in user.");
			}
		}

		public static List<string> GetRegisteredUsers()
		{
			List<string> userList = users.Keys.ToList();
			return userList;
		}
		
		public static List<string> GetLoggedInUsers()
		{
			List<string> loggedUserList = users
				.Where(u => u.Value.LoggedIn == true)
				.Select(u => u.Key)
				.ToList();

			return loggedUserList;
		}

		public static void SetDatabase()
		{
			using (StreamWriter writer = new StreamWriter("user-database.txt"))
			{
				foreach (var user in users)
				{
					writer.WriteLine($"{user.Key} {user.Value.Password} {user.Value.LoggedIn}");
				}
			}
		}

		public static void GetDatabase()
		{
			using (StreamReader reader = new StreamReader("user-database.txt"))
			{
				while (!reader.EndOfStream)
				{
					string[] userData = reader.ReadLine().Split();
					string username = userData[0];
					string password = userData[1];
					bool isLogged = bool.Parse(userData[2]);

					User user = new User(username, password)
					{
						LoggedIn = isLogged
					};

					users.Add(username, user);
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			User.GetDatabase();
			string input = Console.ReadLine();

			while (input != "exit")
			{
				string[] inputTokens = input.Split();
				switch (inputTokens[0])
				{
					case "register":
						User.RegisterUser(inputTokens[1], inputTokens[2], inputTokens[3]);
						break;
					case "login":
						User.Login(inputTokens[1], inputTokens[2]);
						break;
					case "logout":
						User.Logout();
						break;
					default:
						Console.WriteLine("Invalid command. Please try again.");
						break;
				}

				input = Console.ReadLine();
			}

			User.SetDatabase();
		}
	}
}
