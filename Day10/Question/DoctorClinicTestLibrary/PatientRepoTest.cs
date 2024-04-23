using DoctorClinicDALLibrary;
using DoctorClinicModelLibrary;

namespace DoctorClinicTestLibrary
{
    public class PatientRepoTest
    {
        IRepository<int, Patient> repository;
        [SetUp]
        public void Setup()
        {
            repository = new PatientRepo();
        }

        [Test]
        public void AddSuccessTest()
        {
            //Arrange 
            Patient patient = new Patient() { Name = "IT", Department_Head = 101 };
            //Action
            var result = repository.Add(department);
            //Assert
            Assert.AreEqual(1, result.Id);
        }

    }
}