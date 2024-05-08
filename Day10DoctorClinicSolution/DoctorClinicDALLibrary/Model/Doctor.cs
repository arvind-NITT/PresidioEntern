using System;
using System.Collections.Generic;

namespace DoctorClinicDALLibrary.Model
{
    public partial class Doctor
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
