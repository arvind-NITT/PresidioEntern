using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLLibrary
{
    public class DoctorBL : IDoctorServices
    {
        public int AddDoctor(Doctor Doctor)
        {
            throw new DuplicateDoctorNameException();
        }

        public Doctor ChangeDoctorName(string DoctorOldName, string DoctorNewName)
        {
            throw new DoctorNotFoundException();
        }

        public Doctor GetDoctorById(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctorByName(string DoctorName)
        {
            throw new NotImplementedException();
        }

        public bool IsDoctorAvailable(TimeOnly time, int Doctorid)
        {
            throw new NotImplementedException();
        }
    }
}
