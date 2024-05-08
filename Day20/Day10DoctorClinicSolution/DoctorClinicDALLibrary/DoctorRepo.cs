using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorClinicDALLibrary.Model;
using DoctorClinicModelLibrary;
using Doctor = DoctorClinicDALLibrary.Model.Doctor;

namespace DoctorClinicDALLibrary
{
    public class DoctorRepo : IRepository<int, Doctor>
    {
        readonly DoctorClinicDbContext _Doctors;
        public DoctorRepo()
        {
            _Doctors = new DoctorClinicDbContext();
        }

        public Doctor Add(Doctor item)
        {
            _Doctors.Doctors.Add(item);
            _Doctors.SaveChanges();
            return item;
        }

        public Doctor Delete(int key)
        {
            var Doctor = _Doctors.Doctors.Find(key);
            if (Doctor != null)
            {
                _Doctors.Doctors.Remove(Doctor);
                _Doctors.SaveChanges();
                return Doctor;
            }
            return null;
        }

        public Doctor Get(int key)
        {
            return _Doctors.Doctors.Find(key);
        }

        public List<Doctor> GetAll()
        {
            return _Doctors.Doctors.ToList();
        }

        public Doctor Update(Doctor item)
        {
            Doctor existingDoctor = _Doctors.Doctors.Find(item.Id);

            if (existingDoctor != null)
            {
                existingDoctor.Name = item.Name;
                existingDoctor.InTime = item.InTime; 
                existingDoctor.OutTime = item.OutTime;
                _Doctors.Doctors.Update(existingDoctor);
                _Doctors.SaveChanges();
                return existingDoctor;
            }

            return null;
        }


    }
}
