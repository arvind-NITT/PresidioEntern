using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicModelLibrary
{
    public class Appointment
    {
        public int Id { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
