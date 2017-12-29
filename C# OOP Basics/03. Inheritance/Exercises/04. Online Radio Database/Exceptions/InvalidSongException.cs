using System;

namespace _04.Online_Radio_Database.Exceptions
{
    class InvalidSongException : Exception
    {
        public InvalidSongException()
        {
        }

        public InvalidSongException(string message)
            : base(message)
        {
        }

        public InvalidSongException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
