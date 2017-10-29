using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Social_Media_Posts
{
	class Program
	{
		static Dictionary<string, int> postLikes =
			new Dictionary<string, int>();

		static Dictionary<string, int> postDislikes =
			new Dictionary<string, int>();

		static Dictionary<string, Dictionary<string, List<string>>> postComments =
			new Dictionary<string, Dictionary<string, List<string>>>();

		static List<string> existingPostNames =
			new List<string>();

		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "drop the media")
			{
				string[] command = input.Split();
				string action = command[0];
				string postName = command[1];

				switch (action)
				{
					case "like":
						LikePost(postName);
						break;
					case "dislike":
						DislikePost(postName);
						break;
					case "comment":
						string postCommentAuthor = command[2];
						string postComment = string.Join(" ", command.Skip(3));
						CommentPost(postName, postCommentAuthor, postComment);
						break;
					case "post":
						WritePost(postName);
						break;
				}
				input = Console.ReadLine();
			}

			GetAllPostData();
		}

		static void LikePost(string postName)
		{
			// If post doesn't exist do nothing
			if (!existingPostNames.Contains(postName))
			{
				return;
			}

			// We have already created a new Dictionary in WritePost
			// so we just increment the postLikes value
			postLikes[postName]++;
		}

		static void DislikePost(string postName)
		{
			if (!existingPostNames.Contains(postName))
			{
				return;
			}

			postDislikes[postName]++;
		}

		static void CommentPost(string postName, string postCommentAuthor, string postComment)
		{
			if (!existingPostNames.Contains(postName))
			{
				return;
			}

			// Create comment dictionary for postName
			if (!postComments.ContainsKey(postName))
			{
				postComments.Add(postName, new Dictionary<string, List<string>>());
			}

			// Create comments List for comment author
			// (which is not needed if there's only one comment per person)
			if (!postComments[postName].ContainsKey(postCommentAuthor))
			{
				postComments[postName].Add(postCommentAuthor, new List<string>());
			}
			postComments[postName][postCommentAuthor].Add(postComment);
		}

		static void WritePost(string postName)
		{
			if (!existingPostNames.Contains(postName))
			{
				// Here we add the standart 0 likes and dislikes
				// and remember the post name in a List
				existingPostNames.Add(postName);
				postDislikes.Add(postName, 0);
				postLikes.Add(postName, 0);
			}
		}

		static void GetAllPostData()
		{
			// Here we use the List to iterate over all the existing
			// posts so we can show the likes, dislikes and comments
			int existingPostNamesCount = existingPostNames.Count();
			for (int i = 0; i < existingPostNamesCount; i++)
			{
				string currPostName = existingPostNames[i];
				int currPostLikes = postLikes[currPostName];
				int currPostDislikes = postDislikes[currPostName];

				Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}",
					currPostName, currPostLikes, currPostDislikes);
				Console.WriteLine("Comments:");

				if (!postComments.ContainsKey(currPostName))
				{
					Console.WriteLine("None");
				}
				else
				{
					foreach (KeyValuePair<string, List<string>> authorComments in postComments[currPostName])
					{
						string authorName = authorComments.Key;
						List<string> authorCommentsList = authorComments.Value;

						// This for loop is for cases where one user writes 2 or more comments
						int authorCommentsCount = authorCommentsList.Count();
						for (int j = 0; j < authorCommentsCount; j++)
						{
							Console.WriteLine("*  {0}: {1}", authorName, authorCommentsList[j]);
						}
					}
				}
			}
		}
	}
}
