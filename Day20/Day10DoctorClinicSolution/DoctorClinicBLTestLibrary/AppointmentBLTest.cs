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
    public class AppointmentBLTest
    {
        IRepository<int, Appointment> repository;
        IAppointmentServices AppointmentService;
        [SetUp]
        public void Setup()
        {
            repository = new AppointmentRepo();
            DateTime dateTime = DateTime.Now; // Or any other DateTime object
            TimeOnly appointmentTime = TimeOnly.FromDateTime(dateTime);
            Appointment appointment = new Appointment() {  DoctorId=102,PatientId=103,AppointmentTime= appointmentTime };
            repository.Add(appointment);
            AppointmentService = new AppointmentBL(repository);
        }
        [Test]
        public void GetAppointment()
        {
            var appointment = AppointmentService.GetAppointmentById(1);
            Console.WriteLine(appointment);
            Assert.AreEqual(1, appointment.Id);
        }
        [Test]
        public void ChangeAppointmentTime()
        {
            DateTime dateTime = DateTime.Now; // Or any other DateTime object
            TimeOnly appointmentTime = TimeOnly.FromDateTime(dateTime);
            var appointment = AppointmentService.ChangeAppointmentTime(1,appointmentTime);
            Console.WriteLine(appointment);
            Assert.AreEqual(1, appointment.Id);
        }
        [Test]
        public void AddAppointment()
        {
            DateTime dateTime = DateTime.Now; // Or any other DateTime object
            TimeOnly appointmentTime = TimeOnly.FromDateTime(dateTime);
            Appointment appointment = new Appointment() { DoctorId = 102, PatientId = 103, AppointmentTime = appointmentTime };
            var result = AppointmentService.AddAppointment(appointment);
            Console.WriteLine(result);
            Assert.AreEqual(2, result);
        }
    }
}
