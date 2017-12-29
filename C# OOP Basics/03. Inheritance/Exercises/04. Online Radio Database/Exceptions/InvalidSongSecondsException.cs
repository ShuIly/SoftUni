using System;

namespace _04.Online_Radio_Database.Exceptions
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException()
        {
        }

        public InvalidSongSecondsException(string message)
            : base(message)
        {
        }

        public InvalidSongSecondsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}