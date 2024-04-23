using DoctorClinicBLLibrary;
using DoctorClinicDALLibrary;
using DoctorClinicModelLibrary;

namespace DoctorClinicBLTestLibrary
{
 
        public class PatientBLTest
        {
            IRepository<int, Patient> repository;
            IPatientServices PatientService;

            [SetUp]
            public void Setup()
            {
                repository = new PatientRepo();
                Patient patient = new Patient() { Name = "IT", Id=101 };
                repository.Add(patient);
                PatientService = new PatientBL(repository);
            }
        [Test]
        public void GetPatientByNameTest()
        {
            //Action
            var patient = PatientService.GetPatientByName("IT");
            //Assert
            Assert.AreEqual(1, patient.Id);
        }
        [Test]
        public void GetPatientByNameTest1()
        {
            //Action
            var patient = PatientService.GetPatientByName("IT");
            //Assert
            Assert.AreEqual(2, patient.Id);
        }
        [Test]
        public void GetPatientByNameExceptionTest()
        {
            //Action
            var exception = Assert.Throws<PatientNotFoundException>(() => PatientService.GetPatientByName("Admin"));
            //Assert
            Assert.AreEqual("No Patient with such name", exception.Message);
        }
    }
       

}