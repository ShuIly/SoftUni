using System;

namespace _03.Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
			string str = Console.ReadLine();

	        while (true)
	        {
		        int opTagIndex = str.IndexOf("<upcase>", StringComparison.Ordinal);
				if (opTagIndex == -1)
					break;

		        int clTagIndex = str.IndexOf("</upcase>", StringComparison.Ordinal);
				if (clTagIndex == -1)
					break;

		        int tagContentLength = clTagIndex - opTagIndex - 8;
		        string tagContent = str.Substring(opTagIndex + 8, tagContentLength).ToUpper();

		        str = str.Substring(0, opTagIndex + 8)
					+ tagContent
					+ str.Substring(clTagIndex);

		        str = str.Remove(clTagIndex, 9).Remove(opTagIndex, 8);
	        }

	        Console.WriteLine(str);
        }
    }
}