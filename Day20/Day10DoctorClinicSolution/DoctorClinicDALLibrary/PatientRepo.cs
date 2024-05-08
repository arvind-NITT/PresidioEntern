using DoctorClinicDALLibrary.Model;
using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient = DoctorClinicDALLibrary.Model.Patient;

namespace DoctorClinicDALLibrary
{
    public class PatientRepo : IRepository<int, Patient>
    {
        readonly DoctorClinicDbContext _patients;
        public PatientRepo()
        {
            _patients = new DoctorClinicDbContext();
        }
       
        public Patient Add(Patient item)
        {
            _patients.Patients.Add(item);
            _patients.SaveChanges();
            return item;
        }

        public Patient Delete(int key)
        {
            var patient = _patients.Patients.Find(key);
            if (patient != null)
            {
                _patients.Patients.Remove(patient);
                _patients.SaveChanges();
                return patient;
            }
            return null;
        }

        public Patient Get(int key)
        {
            return _patients.Patients.Find(key);
        }

        public List<Patient> GetAll()
        {
            return _patients.Patients.ToList();
        }

        public Patient Update(Patient item)
        {
            Patient existingPatient = _patients.Patients.Find(item.Id);

            if (existingPatient != null)
            {
                existingPatient.Name = item.Name;

                _patients.Patients.Update(existingPatient);
                _patients.SaveChanges();
                return existingPatient;
            }
            
            return null;
        }
    }
}
