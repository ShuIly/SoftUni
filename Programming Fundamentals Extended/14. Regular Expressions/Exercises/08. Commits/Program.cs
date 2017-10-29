using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.Commits
{
	class Commit
	{
		public string Hash { get; set; }
		public string Message { get; set; }
		public int Additions { get; set; }
		public int Deletions { get; set; }

		public Commit(string hash, string message, int additions, int deletions)
		{
			Hash = hash;
			Message = message;
			Additions = additions;
			Deletions = deletions;
		}

		public override string ToString()
		{
			string result = $"commit {Hash}: {Message} ({Additions} additions, {Deletions} deletions)";
			return result;
		}
	}

	class Repository
	{
		public string Name { get; set; }
		public List<Commit> Commits { get; set; }

		public Repository(string name)
		{
			Name = name;
			Commits = new List<Commit>();
		}
	}

	class User
	{
		public string Username { get; set; }
		public Dictionary<string, Repository> Repositories { get; set; }

		public User(string username)
		{
			Username = username;
			Repositories = new Dictionary<string, Repository>();
		}

		public void AddRepository(Repository repository)
		{
			string repositoryName = repository.Name;
			if (!Repositories.ContainsKey(repositoryName))
			{
				Repositories.Add(repositoryName, repository);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string regex = @"^https:\/\/github\.com\/(?<user>[a-zA-Z\d-]+?)\/(?<repo>[a-zA-Z-_]+?)\/commit\/(?<hash>[\da-f]{40}),(?<message>[^\n]+?),(?<additions>\d+?),(?<deletions>\d+)$";
			string input = Console.ReadLine();
			Dictionary<string, User> users = new Dictionary<string, User>();

			while (input != "git push")
			{
				Match match = Regex.Match(input, regex);
				if (match.Success)
				{
					string username = match.Groups["user"].Value;
					string repositoryName = match.Groups["repo"].Value;
					string hash = match.Groups["hash"].Value;
					string message = match.Groups["message"].Value;
					int additions = int.Parse(match.Groups["additions"].Value);
					int deletions = int.Parse(match.Groups["deletions"].Value);

					Commit commit = new Commit(hash, message, additions, deletions);
					Repository repository = new Repository(repositoryName);
					if (!users.ContainsKey(username))
					{
						User user = new User(username);
						users.Add(username, user);
					}

					users[username].AddRepository(repository);
					users[username].Repositories[repositoryName].Commits.Add(commit);
				}

				input = Console.ReadLine();
			}

			foreach (string username in users.Keys
				.OrderBy(u => u))
			{
				Console.WriteLine($"{username}:");
				foreach (string repository in users[username].Repositories.Keys
					.OrderBy(r => r))
				{
					Console.WriteLine($"  {repository}:");

					int totalAdditions = 0;
					int totalDeletions = 0;
					foreach (Commit commit in users[username].Repositories[repository].Commits)
					{
						totalAdditions += commit.Additions;
						totalDeletions += commit.Deletions;
						Console.WriteLine($"    {commit}");
					}

					Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
				}
			}
		}
	}
}
