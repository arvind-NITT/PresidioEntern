using DoctorClinicModelLibrary;
using DoctorClinicBLLibrary;
using DoctorClinicDALLibrary;
namespace DoctorClinicApp
{
    public class Program
    {
        void AddPatient()
        {

            PatientBL PatientBL = new PatientBL(new PatientRepo());
            try
            {
                Console.WriteLine("Pleae enter the Patient name");
                string name = Console.ReadLine();
                Patient Patient = new Patient() { Name = name };
                int id = PatientBL.AddPatient(Patient);
                Console.WriteLine("Congrats. We ahve created the Patient for you and the Id is " + id);
                Console.WriteLine("Pleae enter the Patient name");
                name = Console.ReadLine();
                Patient = new Patient() { Name = name };
                id = PatientBL.AddPatient(Patient);
                Console.WriteLine("Congrats. We ahve created the Patient for you and the Id is " + id);
            }
            catch (DuplicatePatientNameException ddne)
            {
                Console.WriteLine(ddne.Message);
            }
        }


        static void Main(string[] args)
        {
            new Program().AddPatient();
        }
    }
}
