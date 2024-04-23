using DoctorClinicBLLibrary;
using DoctorClinicDALLibrary;
using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLTestLibrary
{
    public class DoctorBLTest
    {
        IRepository<int, Doctor> repository;
        IDoctorServices DoctorService;

        [SetUp]
        public void Setup()
        {
            repository = new DoctorRepo();
            DateTime inTime = DateTime.Now; // Or any other DateTime object
            TimeOnly appointmentTime = TimeOnly.FromDateTime(inTime);
            DateTime OutTime = DateTime.Now;
            TimeOnly appointmentTime1 = TimeOnly.FromDateTime(OutTime);
            TimeSpan tenMinutes = TimeSpan.FromMinutes(10);
            DateTime appointmentDateTime = DateTime.Today.Add(tenMinutes);
            DateTime newDateTime = appointmentDateTime.Add(tenMinutes);
            TimeOnly newAppointmentTime = TimeOnly.FromDateTime(newDateTime);

            Doctor Doctor = new Doctor() { Name = "Arvind", Id = 101,InTime= appointmentTime,OutTime=newAppointmentTime };
            repository.Add(Doctor);
            DoctorService = new DoctorBL(repository);
        }
        [Test]
        public void GetDoctorByNameTest()
        {
            //Action
            var Doctor = DoctorService.GetDoctorByName("Arvind");
            //Assert
            Assert.AreEqual(1, Doctor.Id);
        }
        [Test]
        public void GetDoctorByNameTest1()
        {
            //Action
            var Doctor = DoctorService.GetDoctorByName("Arvind");
            //Assert
            Assert.AreEqual(2, Doctor.Id);
        }
        [Test]
        public void GetDoctorByNameExceptionTest()
        {
            //Action
            var exception = Assert.Throws<DoctorNotFoundException>(() => DoctorService.GetDoctorByName("Admin"));
            //Assert
            Assert.AreEqual("No Doctor with such name", exception.Message);
        }
        [Test]
        public void IsDoctorAvailableTest()
        {
            //Action
            DateTime inTime = DateTime.Now; // Or any other DateTime object
            TimeOnly appointmentTime = TimeOnly.FromDateTime(inTime);
            var Doctor = DoctorService.IsDoctorAvailable(appointmentTime,1);
            //Assert
            Assert.AreEqual(true, Doctor);
        }
    }
}
