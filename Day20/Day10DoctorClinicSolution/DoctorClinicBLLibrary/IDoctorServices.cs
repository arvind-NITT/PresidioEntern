using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLLibrary
{
    public interface IDoctorServices
    {
        int AddDoctor(Doctor Doctor);
        Doctor ChangeDoctorName(string DoctorOldName, string DoctorNewName);
        Doctor GetDoctorById(int id);
        Doctor GetDoctorByName(string DoctorName);

        bool IsDoctorAvailable(TimeOnly time,int Doctorid);

    }
}
