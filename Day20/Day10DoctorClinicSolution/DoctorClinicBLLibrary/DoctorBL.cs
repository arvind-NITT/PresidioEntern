using DoctorClinicDALLibrary;
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
        readonly IRepository<int, Doctor> _DoctorRepository;
        public DoctorBL(IRepository<int, Doctor> DoctorRepository)
        {
            //_DoctorRepository = new DoctorRepository();//Tight coupling
            _DoctorRepository = DoctorRepository;//Loose coupling
        }
        public int AddDoctor(Doctor Doctor)
        {
            var result = _DoctorRepository.Add(Doctor);
            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicateDoctorNameException();
        }

        public Doctor ChangeDoctorName(string DoctorOldName, string DoctorNewName)
        {
            throw new DoctorNotFoundException();
        }

        public Doctor GetDoctorById(int id)
        {
            var Doctors = _DoctorRepository.GetAll();
            for (int i = 0; i < Doctors.Count; i++)
                if (Doctors[i].Id == id)
                    return Doctors[i];
            throw new DoctorNotFoundException();
        }

        public Doctor GetDoctorByName(string DoctorName)
        {
            var Doctors = _DoctorRepository.GetAll();
            for (int i = 0; i < Doctors.Count; i++)
                if (Doctors[i].Name == DoctorName)
                    return Doctors[i];
            throw new DoctorNotFoundException();
        }

        public bool IsDoctorAvailable(TimeOnly time, int Doctorid)
        {
            var doctor = _DoctorRepository.Get(Doctorid) ?? throw new DoctorNotFoundException();
            if (doctor.InTime < time &&  doctor.OutTime > time) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
