using System.Runtime.Serialization;

namespace DoctorClinicBLLibrary
{
    [Serializable]
    public class DuplicateDoctorNameException : Exception
    {
        string msg;
        public DuplicateDoctorNameException()
        {
            msg = "Doctor Name already Exist";
        }
        public override string Message => msg;
    }
}