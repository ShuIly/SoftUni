using System;
using System.Collections.Generic;
using System.Linq;
using _04.Online_Radio_Database;
using _04.Online_Radio_Database.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        List<Song> songs = new List<Song>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] songArgs = Console.ReadLine()
                .Split(new[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                songs.Add(new Song(songArgs[0], songArgs[1], int.Parse(songArgs[2]), int.Parse(songArgs[3])));
                Console.WriteLine("Song added.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid song length.");
            }
            catch (InvalidSongException iex)
            {
                Console.WriteLine(iex.Message);
            }
        }

        int secondsSum = songs.Sum(s => s.Seconds);
        int minutesSum = songs.Sum(s => s.Minutes);

        Console.WriteLine("Songs added: " + songs.Count);
        Console.WriteLine("Playlist length: " + GetTime(minutesSum, secondsSum));
    }

    static string GetTime(int minutes, int seconds)
    {
        int resultSeconds = seconds % 60;
        int resultMinutes = minutes + seconds / 60;
        int resultHours = resultMinutes / 60;

        resultMinutes %= 60;

        return $"{resultHours}h {resultMinutes}m {resultSeconds}s";
    }
}
