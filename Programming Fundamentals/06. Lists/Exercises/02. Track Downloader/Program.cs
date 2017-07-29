using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> tracks = new List<string>();

			string[] blacklited = Console.ReadLine().Split();
			string currTrack = Console.ReadLine();

			while (currTrack != "end")
			{
				bool isBlacklisted = false;

				for (int i = 0; i < blacklited.Length; i++)
				{
					if (currTrack.Contains(blacklited[i]))
					{
						isBlacklisted = true;
						break;
					}
				}

				if (!isBlacklisted)
				{
					tracks.Add(currTrack);
				}

				currTrack = Console.ReadLine();
			}

			tracks.Sort();

			Console.WriteLine(string.Join(Environment.NewLine, tracks));
		}
	}
}
