namespace DoctorClinicBLLibrary
{

    public class PatientNotFoundException : Exception
    {
        string message;
        public PatientNotFoundException()
        {
            message = "No Patient with such name";
        }
        public PatientNotFoundException(string name)
        {
            message = "No Patient with name {name}";
        }
        public override string Message => message;
    }
}