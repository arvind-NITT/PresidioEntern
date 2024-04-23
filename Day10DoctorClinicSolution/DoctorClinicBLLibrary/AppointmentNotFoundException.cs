using System.Runtime.Serialization;

namespace DoctorClinicBLLibrary
{
    [Serializable]
    public class AppointmentNotFoundException : Exception
    {
        string message;
        public AppointmentNotFoundException()
        {
            message = "No Appointment with such name";
        }
        public AppointmentNotFoundException(string name)
        {
            message = "No Appointment with name {name}";
        }
        public override string Message => message;
    }
}