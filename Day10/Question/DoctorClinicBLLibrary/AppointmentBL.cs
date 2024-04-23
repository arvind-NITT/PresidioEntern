using DoctorClinicDALLibrary;
using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLLibrary
{
    public class AppointmentBL : IAppointmentServices
    {

        readonly IRepository<int, Appointment> _AppointmentRepository;
        public AppointmentBL(IRepository<int, Appointment> AppointmentRepository)
        {
            //_AppointmentRepository = new AppointmentRepository();//Tight coupling
            _AppointmentRepository = AppointmentRepository;//Loose coupling
        }
        public int AddAppointment(Appointment Appointment)
        {

            var result = _AppointmentRepository.Add(Appointment);
            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicateAppointmentNameException();


        }



        public Appointment ChangeAppointmentTime(int DoctorId, int PatientId, TimeOnly NewTime)
        {
            throw new NotImplementedException();
        }

        public Appointment GetAppointmentById(int id)
        {
            Appointment Appointment = _AppointmentRepository.Get(id);
            if (Appointment != null)
            {
                return Appointment;
            }
            throw new AppointmentNotFoundException();
        }




    }
}
