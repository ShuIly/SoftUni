using System;

namespace _04.Online_Radio_Database.Exceptions
{
    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException()
        {
        }

        public InvalidArtistNameException(string message)
            : base(message)
        {
        }

        public InvalidArtistNameException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
