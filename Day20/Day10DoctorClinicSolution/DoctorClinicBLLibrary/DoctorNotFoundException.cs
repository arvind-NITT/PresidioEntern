using System.Runtime.Serialization;

namespace DoctorClinicBLLibrary
{
    [Serializable]
    public class DoctorNotFoundException : Exception
    {
        string message;
        public DoctorNotFoundException()
        {
            message = "No Doctor with such name";
        }
        public DoctorNotFoundException(string name)
        {
            message = "No Doctor with name {name}";
        }
        public override string Message => message;
    }
}