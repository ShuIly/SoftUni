
namespace _04.Online_Radio_Database
{
    using Exceptions;

    class Song
    {
        private const int MaxAuthorNameLength = 20;
        private const int MinAuthorNameLength = 3;
        private const int MaxSongNameLength = 30;
        private const int MinSongNameLength = 3;
        private const int MaxSongMinutes = 14;
        private const int MaxSongSeconds = 59;

        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public string ArtistName
        {
            get => this.artistName;
            set
            {
                if (value.Length < MinAuthorNameLength || value.Length > MaxAuthorNameLength)
                {
                    throw new InvalidArtistNameException($"Artist name should be between {MinAuthorNameLength} and {MaxAuthorNameLength} symbols.");
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;
            set
            {
                if (value.Length < MinAuthorNameLength || value.Length > MaxSongNameLength)
                {
                    throw new InvalidArtistNameException($"Song name should be between {MinSongNameLength} and {MaxSongNameLength} symbols.");
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            set
            {
                if (value < 0 || value > MaxSongMinutes)
                {
                    throw new InvalidSongMinutesException($"Song minutes should be between 0 and {MaxSongMinutes}.");
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            set
            {
                if (value < 0 || value > MaxSongSeconds)
                {
                    throw new InvalidSongSecondsException($"Song seconds should be between 0 and {MaxSongSeconds}.");
                }

                this.seconds = value;
            }
        }

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
