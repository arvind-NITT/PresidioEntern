using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicModelLibrary
{
    public class Doctor
    {
        public Doctor() { }
        public Doctor(string name) { }
        public string Name { get; set; }
        public int Id { get; set; }

        public TimeOnly InTime {  get; set; }

        public TimeOnly OutTime { get; set; }
       

    }
}
