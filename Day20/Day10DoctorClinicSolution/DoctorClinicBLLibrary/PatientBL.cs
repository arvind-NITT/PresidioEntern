﻿using DoctorClinicDALLibrary;
using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLLibrary
{
    public class PatientBL : IPatientServices
    {
        readonly IRepository<int, Patient> _PatientRepository;
        public PatientBL(IRepository<int, Patient> PatientRepository)
        {
            //_PatientRepository = new PatientRepository();//Tight coupling
            _PatientRepository = PatientRepository;//Loose coupling
        }
        public int AddPatient(Patient Patient)
        {
            var result = _PatientRepository.Add(Patient);
            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicatePatientNameException();
        }

        public Patient ChangePatientName(string PatientOldName, string PatientNewName)
        {
            throw new PatientNotFoundException();
        }

        public Patient GetPatientById(int id)
        {
            var Patients = _PatientRepository.GetAll();
            for (int i = 0; i < Patients.Count; i++)
                if (Patients[i].Id == id)
                    return Patients[i];
            throw new PatientNotFoundException();
        }

        public Patient GetPatientByName(string PatientName)
        {
            var Patients = _PatientRepository.GetAll();
            for (int i = 0; i < Patients.Count; i++)
                if (Patients[i].Name == PatientName)
                    return Patients[i];
            throw new PatientNotFoundException();
        }

        public bool IsPatientAppointmentAlreadyExist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
