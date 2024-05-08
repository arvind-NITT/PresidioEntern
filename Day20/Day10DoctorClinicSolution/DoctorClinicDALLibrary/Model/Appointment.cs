using System;
using System.Collections.Generic;

namespace DoctorClinicDALLibrary.Model
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        public int? DoctorId { get; set; }
        public int? PatientId { get; set; }

        public virtual Doctor? Doctor { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
