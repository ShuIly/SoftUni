using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _13.Сръбско_Unleashed
{
	class Venue
	{
		public string Name { get; set; }
		public Dictionary<string, long> Singers { get; set; }

		public Venue(string name)
		{
			Name = name;
			Singers = new Dictionary<string, long>();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			// You can test this regex in regex101.
	        string regex = @"^(?<singer>[A-Za-z]+(?:\s[A-Za-z]+)*?)\s@(?<venue>[A-Za-z]+(?:\s[A-Za-z]+)*?)\s(?<price>\d+)\s(?<count>\d+)$";
			var venues = new Dictionary<string, Venue>();

	        while (true)
	        {
		        string input = Console.ReadLine();
				if (input == "End")
					break;

		        Match singerMatch = Regex.Match(input, regex);
				if (!singerMatch.Success)
					continue;

		        string singer = singerMatch.Groups["singer"].Value;
		        string venue = singerMatch.Groups["venue"].Value;
		        int ticketPrice = int.Parse(singerMatch.Groups["price"].Value);
		        int ticketCount = int.Parse(singerMatch.Groups["count"].Value);

		        long venuePrice = ticketPrice * ticketCount;

				if (!venues.ContainsKey(venue))
					venues.Add(venue, new Venue(venue));

		        if (!venues[venue].Singers.ContainsKey(singer))
			        venues[venue].Singers.Add(singer, venuePrice);
		        else
			        venues[venue].Singers[singer] += venuePrice;
	        }

	        string result = "";
	        foreach (string venue in venues.Keys)
	        {
		        result += $"{venue}\n";
		        foreach (var singer in venues[venue].Singers
					.OrderByDescending(s => s.Value))
		        {
			        result += $"#  {singer.Key} -> {singer.Value}\n";
		        }
	        }

	        Console.WriteLine(result);
        }
    }
}