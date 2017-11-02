using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Files
{
	class File
	{
		public string Name { get; set; }
		public string Extension { get; set; }
		public long FileSize { get; set; }

		public File(string name, long fileSize)
		{
			Name = name;
			FileSize = fileSize;

			Extension = Regex.Match(name, @"^.+\.(?<extension>.+)$")
				.Groups["extension"]
				.Value;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string regex =
				@"^(?<root>.+?)\\.+?\\(?:.+?\\)*(?<filename>.+\..+);(?<directorysize>\d+)$";

			var directory = new Dictionary<string, Dictionary<string, File>>();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Match match = Regex.Match(Console.ReadLine(), regex);
				// Check for match success (10th test runtime error)
				if (!match.Success)
					continue;

				string root = match.Groups["root"].Value;
				string filename = match.Groups["filename"].Value;
				long fileSize = long.Parse(match.Groups["directorysize"].Value);

				if (!directory.ContainsKey(root))
					directory.Add(root, new Dictionary<string, File>());

				directory[root][filename] = new File(filename, fileSize);
			}

			string[] inputTokens = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string extension = inputTokens[0];
			string dir = inputTokens[2];

			if (directory.ContainsKey(dir) && directory[dir].Values
				.Any(f => f.Extension == extension))
			{
				string result = "";
				foreach (File file in directory[dir].Values
					.Where(f => f.Extension == extension)
					.OrderByDescending(f => f.FileSize)
					.ThenBy(f => f.Name))
				{
					result += $"{file.Name} - {file.FileSize} KB\n";
				}

				Console.WriteLine(result);
			}
			else
				Console.WriteLine("No");
		}
	}
}