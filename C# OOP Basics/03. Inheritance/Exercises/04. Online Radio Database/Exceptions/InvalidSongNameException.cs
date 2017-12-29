using System;

namespace _04.Online_Radio_Database.Exceptions
{
    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException()
        {
        }

        public InvalidSongLengthException(string message)
            : base(message)
        {
        }

        public InvalidSongLengthException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
