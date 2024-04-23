using System.Runtime.Serialization;

namespace DoctorClinicBLLibrary
{
    [Serializable]
    public class DuplicateAppointmentNameException : Exception
    {
        string msg;
        public DuplicateAppointmentNameException()
        {

            msg = "Appointment Name already Exist";
        }
        public override string Message => msg;
    }
}