using System.Runtime.Serialization;

namespace DoctorClinicAPI.Exceptions
{
    [Serializable]
    internal class NoSuchdoctorsException : Exception
    {
        public NoSuchdoctorsException()
        {
        }

        public NoSuchdoctorsException(string? message) : base(message)
        {
        }

        public NoSuchdoctorsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchdoctorsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}