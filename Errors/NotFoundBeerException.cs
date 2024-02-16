using System.Runtime.Serialization;

namespace ConsoleApp1.Errors
{
    internal class NotFoundBeerException : Exception
    {
        public NotFoundBeerException()
        {
        }

        protected NotFoundBeerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NotFoundBeerException(string? message) : base(message)
        {
        }

        public NotFoundBeerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
