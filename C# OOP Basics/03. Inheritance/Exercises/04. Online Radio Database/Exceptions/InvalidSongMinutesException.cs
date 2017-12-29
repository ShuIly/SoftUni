using System;

namespace _04.Online_Radio_Database.Exceptions
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException()
        {
        }

        public InvalidSongMinutesException(string message)
            : base(message)
        {
        }

        public InvalidSongMinutesException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
