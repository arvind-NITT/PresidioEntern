using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLLibrary
{
    public interface IAppointmentServices
    {
        int AddAppointment(Appointment Appointment);
        Appointment ChangeAppointmentTime(int DoctorId, int PatientId,TimeOnly NewTime);
        Appointment GetAppointmentById(int id);

    }
}
