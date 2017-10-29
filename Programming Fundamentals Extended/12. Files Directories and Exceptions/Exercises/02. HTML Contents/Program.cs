using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HTML_Contents
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> htmlElements = new List<string>();
			string title = "Document";

			string input = Console.ReadLine();

			while (input != "exit")
			{
				string[] inputTokens = input.Split();
				
				if (inputTokens[0] == "title")
				{
					title = inputTokens[1];
				}
				else
				{
					string tag = inputTokens[0];
					string content = inputTokens[1];
					htmlElements.Add($"\t<{tag}>{content}</{tag}>");
				}

				input = Console.ReadLine();
			}

			File.WriteAllText("output.txt", "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n");
			File.AppendAllText("output.txt", $"<title>{title}</title>\r\n</head>\r\n<body>\r\n");
			File.AppendAllLines("output.txt", htmlElements);
			File.AppendAllText("output.txt", "</body>\r\n</html>");
		}
	}
}
