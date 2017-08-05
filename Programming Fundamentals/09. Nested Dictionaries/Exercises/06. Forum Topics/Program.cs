using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Forum_Topics
{
	class Program
	{
		static void Main(string[] args)
		{
			var topics = new Dictionary<string, HashSet<string>>();
			string command = Console.ReadLine();

			while (command != "filter")
			{
				string[] subCommand = command.Split(new string[] { " -> " },
					StringSplitOptions.RemoveEmptyEntries);
				string[] topicTags = subCommand[1].Split(new string[] { ", " },
					StringSplitOptions.RemoveEmptyEntries);
				string topicName = subCommand[0];

				int tagCount = topicTags.Length;
				for (int i = 0; i < tagCount; i++)
				{
					if (!topics.ContainsKey(topicName))
					{
						topics.Add(topicName, new HashSet<string>());
					}
					topics[topicName].Add($"#{topicTags[i]}");
				}

				command = Console.ReadLine();
			}

			string searchTopics = Console.ReadLine();
			string[] topicArr = searchTopics.Split(new string[] { ", " },
					StringSplitOptions.RemoveEmptyEntries);

			foreach (KeyValuePair<string, HashSet<string>> currTopic in topics)
			{
				HashSet<string> currTopicTags = currTopic.Value;
				string currTopicName = currTopic.Key;
				bool containsAllTags = true;
				int topicArrCount = topicArr.Length;

				for (int i = 0; i < topicArrCount; i++)
				{
					if (!currTopicTags.Contains($"#{topicArr[i]}"))
					{
						containsAllTags = false;
						break;
					}
				}

				if (containsAllTags)
				{
					Console.WriteLine("{0} | {1}", currTopicName, string.Join(", ", currTopicTags));
				}
			}
		}
	}
}
