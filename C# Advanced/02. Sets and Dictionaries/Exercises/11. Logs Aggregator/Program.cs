using System;
using System.Collections.Generic;

namespace _11.Logs_Aggregator
{
	class User
	{
		public string Name { get; set; }
		public int SessionDuration { get; set; }
		public SortedSet<string> IPs { get; set; }

		public User(string username)
		{
			Name = username;
			IPs = new SortedSet<string>();
			SessionDuration = 0;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			var users = new SortedDictionary<string, User>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        string[] inputTokens = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

		        string ip = inputTokens[0];
		        string username = inputTokens[1];
		        int duration = int.Parse(inputTokens[2]);

				if (!users.ContainsKey(username))
					users.Add(username, new User(username));

		        users[username].SessionDuration += duration;
		        users[username].IPs.Add(ip);
	        }

	        string result = "";
	        foreach (string user in users.Keys)
	        {
		        result += $"{user}: {users[user].SessionDuration} "
					+ $"[{string.Join(", ", users[user].IPs)}]\n";
	        }

			Console.WriteLine(result);
        }
    }
}