using System.Runtime.Serialization;

namespace DoctorClinicAPI.Exceptions
{
    [Serializable]
    public class NoDoctorFoundException : Exception
    {
            string msg;
        public NoDoctorFoundException()
        {
            msg = "Doctor Name already Exist";
        }
        public override string Message => msg;



    }
}