using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorClinicModelLibrary;
using DoctorClinicDALLibrary.Model;
using Appointment = DoctorClinicDALLibrary.Model.Appointment;
namespace DoctorClinicDALLibrary
{
    public class AppointmentRepo : IRepository<int, Appointment>
    {


        readonly DoctorClinicDbContext _Appointments;
        public AppointmentRepo()
        {
            _Appointments = new DoctorClinicDbContext();
        }

        public Appointment Add(Appointment item)
        {
            _Appointments.Appointments.Add(item);
            _Appointments.SaveChanges();
            return item;
        }

        public Appointment Delete(int key)
        {
            var Appointment = _Appointments.Appointments.Find(key);
            if (Appointment != null)
            {
                _Appointments.Appointments.Remove(Appointment);
                _Appointments.SaveChanges();
                return Appointment;
            }
            return null;
        }

        public Appointment Get(int key)
        {
            return _Appointments.Appointments.Find(key);
        }

        public List<Appointment> GetAll()
        {
            return _Appointments.Appointments.ToList();
        }

        public Appointment Update(Appointment item)
        {
            Appointment existingAppointment = _Appointments.Appointments.Find(item.Id);

            if (existingAppointment != null)
            {
                existingAppointment.AppointmentTime = item.AppointmentTime; 
                existingAppointment.DoctorId = item.DoctorId;
                existingAppointment.PatientId = item.PatientId;

                _Appointments.Appointments.Update(existingAppointment);
                _Appointments.SaveChanges();
                return existingAppointment;
            }

            return null;
        }
    }
}
