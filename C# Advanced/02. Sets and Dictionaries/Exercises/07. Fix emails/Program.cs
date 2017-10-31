using System;
using System.Collections.Generic;

namespace _07.Fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {
	        var credessentials = new Dictionary<string, string>();

	        while (true)
	        {
		        string user = Console.ReadLine();

				if (user == "stop")
					break;

		        string email = Console.ReadLine();
				string emailDomain = email
					.Substring(email.LastIndexOf('.') + 1)
					.ToLower();

		        if (emailDomain != "us" && emailDomain != "uk")
			        credessentials[user] = email;
	        }

	        string result = "";
	        foreach (var cr in credessentials)
	        {
		        result += $"{cr.Key} -> {cr.Value}\n";
	        }

	        Console.WriteLine(result);
        }
    }
}