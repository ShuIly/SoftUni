using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> users = new Dictionary<string, string>();
			string register = Console.ReadLine();

			while (register != "login")
			{
				string[] userInfo = register.Split();
				string username = userInfo[0];
				string password = userInfo[2];

				users[username] = password;

				register = Console.ReadLine();
			}

			string login = Console.ReadLine();
			int failedLogin = 0;

			while (login != "end")
			{
				string[] userInfo = login.Split();
				string username = userInfo[0];
				string password = userInfo[2];

				if (users.ContainsKey(username))
				{
					if (users[username] == password)
					{
						Console.WriteLine($"{username}: logged in successfully");
					}
					else
					{
						Console.WriteLine($"{username}: login failed");
						failedLogin++;
					}
				}
				else
				{
					Console.WriteLine($"{username}: login failed");
					failedLogin++;
				}

				login = Console.ReadLine();
			}

			Console.WriteLine($"unsuccessful login attempts: {failedLogin}");
		}
	}
}
