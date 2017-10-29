using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
	class User
	{
		public string Username { get; set; }
		public List<Message> Messages { get; set; }

		public User(string username)
		{
			Username = username;
			Messages = new List<Message>();
		}
	}

	class Message
	{
		public string Sender { get; set; }
		public string Content { get; set; }

		public Message(string sender, string content)
		{
			Sender = sender;
			Content = content;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var userList = new Dictionary<string, User>();

			while (input != "exit")
			{
				string[] inputTokens = input.Split();

				if (inputTokens[0] == "register")
				{
					string username = inputTokens[1];
					if (!userList.ContainsKey(username))
					{
						userList[username] = new User(username);
					}
				}
				else
				{
					string sender = inputTokens[0];
					string recipient = inputTokens[2];
					string content = inputTokens[3];

					if (userList.ContainsKey(sender) && userList.ContainsKey(recipient))
					{
						userList[recipient].Messages.Add(new Message(sender, content));
					}
				}

				input = Console.ReadLine();
			}

			input = Console.ReadLine();
			string[] newInputTokens = input.Split();
			string firstUser = newInputTokens[0];
			string secondUser = newInputTokens[1];

			string[] firstUserMessages = userList[firstUser]
				.Messages
				.Where(m => m.Sender == secondUser)
				.Select(m => m.Content)
				.ToArray();

			string[] secondUserMessages = userList[secondUser]
				.Messages
				.Where(m => m.Sender == firstUser)
				.Select(m => m.Content)
				.ToArray();

			int firstUserIndex = 0;
			int secondUserIndex = 0;

			if (firstUserMessages.Length == 0 &&
				secondUserMessages.Length == 0)
			{
				Console.WriteLine("No messages");
			}
			else
			{
				while (firstUserIndex < firstUserMessages.Length
					&& secondUserIndex < secondUserMessages.Length)
				{
					string secondUserContent = secondUserMessages[secondUserIndex];
					Console.WriteLine($"{firstUser}: {secondUserContent}");

					string firstUserContent = firstUserMessages[firstUserIndex];
					Console.WriteLine($"{firstUserContent} :{secondUser}");

					firstUserIndex++;
					secondUserIndex++;
				}

				if (firstUserIndex < firstUserMessages.Length)
				{
					while (firstUserIndex < firstUserMessages.Length)
					{
						string firstUserContent = firstUserMessages[firstUserIndex];
						Console.WriteLine($"{firstUserContent} :{secondUser}");

						firstUserIndex++;
					}
				}
				else
				{
					while (secondUserIndex < secondUserMessages.Length)
					{
						string secondUserContent = secondUserMessages[secondUserIndex];
						Console.WriteLine($"{firstUser}: {secondUserContent}");

						secondUserIndex++;
					}
				}
			}
		}
	}
}