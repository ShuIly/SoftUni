using System;

namespace _02.Parse_URLs
{
    class Program
    {
	    static bool IsUrlValid(string url)
	    {
		    int firstProtocolIndex = url.IndexOf("://", StringComparison.Ordinal);
		    if (firstProtocolIndex == -1 || firstProtocolIndex != url.LastIndexOf("://", StringComparison.Ordinal))
			    return false;

		    int firstResourceSeparator = url.IndexOf("/", firstProtocolIndex + 3, StringComparison.Ordinal);
		    return firstResourceSeparator != -1;
	    }

        static void Main(string[] args)
        {
			string url = Console.ReadLine();
	        if (!IsUrlValid(url))
	        {
		        Console.WriteLine("Invalid URL");
				return;
	        }

	        int protocolSeparatorIndex = url.IndexOf("://", StringComparison.Ordinal);
	        int serverSeparatorIndex = url.IndexOf("/", protocolSeparatorIndex + 3, StringComparison.Ordinal);
	        int serverLength = serverSeparatorIndex - protocolSeparatorIndex - 3;

			string protocol = url.Substring(0, url.IndexOf("://", StringComparison.Ordinal));
	        string server = url.Substring(protocolSeparatorIndex + 3, serverLength);
			string resources = url.Substring(serverSeparatorIndex + 1);

	        Console.WriteLine($"Protocol = {protocol}");
	        Console.WriteLine($"Server = {server}");
	        Console.WriteLine($"Resources = {resources}");
        }
    }
}