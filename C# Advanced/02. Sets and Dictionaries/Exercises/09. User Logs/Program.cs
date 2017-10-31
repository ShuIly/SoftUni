using System;
using System.Collections.Generic;

namespace _09.User_Logs
{
	class IP
	{
		public string Name { get; set; }
		public int Count { get; set; }

		public IP (string name)
		{
			Name = name;
			Count = 1;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        var users = new SortedDictionary<string, Dictionary<string, int>>();

	        while (true)
	        {
				string input = Console.ReadLine();
				if (input == "end")
					break;

		        string[] inputTokens = input
			        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

		        string ip = inputTokens[0].Substring(inputTokens[0].IndexOf('=') + 1);
		        string username = inputTokens[2].Substring(inputTokens[2].IndexOf('=') + 1);

				if (!users.ContainsKey(username))
					users.Add(username, new Dictionary<string, int>());

				if (!users[username].ContainsKey(ip))
					users[username].Add(ip, 0);

		        users[username][ip]++;
	        }

	        string result = "";
	        foreach (string username in users.Keys)
	        {
				Queue<string> dictToQueue = new Queue<string>();
		        foreach (var ip in users[username])
		        {
			        dictToQueue.Enqueue($"{ip.Key} => {ip.Value}");
		        }

		        result += $"{username}: \n{string.Join(", ", dictToQueue)}.\n";
	        }

	        Console.WriteLine(result);
        }
    }
}