using System.Runtime.Serialization;

namespace DoctorClinicBLLibrary
{
    [Serializable]
    public class DuplicatePatientNameException : Exception
    {
        string msg;
        public DuplicatePatientNameException()
        {
            msg = "Patient Name already Exist";
        }
        public override string Message => msg;
    }
}