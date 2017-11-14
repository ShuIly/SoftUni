using System;

namespace _03.Parse_Tags_V2
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string openingTag = "<upcase>";
			string closingTag = "</upcase>";

			while (true)
			{
				int opTagIndex = str.IndexOf(openingTag, StringComparison.Ordinal);
				if (opTagIndex == -1)
					break;

				int clTagIndex = str.IndexOf(closingTag, StringComparison.Ordinal);
				if (clTagIndex == -1)
					break;

				int contentLength = clTagIndex - opTagIndex;
				string tagsAndContent = str.Substring(opTagIndex, contentLength + closingTag.Length);

				string upperCaseContent = tagsAndContent
					.Replace(openingTag, "")
					.Replace(closingTag, "")
					.ToUpper();

				str = str.Replace(tagsAndContent, upperCaseContent);
			}

			Console.WriteLine(str);
		}
	}
}