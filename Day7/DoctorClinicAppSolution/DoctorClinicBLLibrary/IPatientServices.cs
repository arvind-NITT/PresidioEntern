﻿using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClinicBLLibrary
{
    internal interface IPatientServices
    {
        int AddPatient(Patient Patient);
        Patient ChangePatientName(string PatientOldName, string PatientNewName);
        Patient GetPatientById(int id);
        Patient GetPatientByName(string PatientName);

        bool IsPatientAppointmentAlreadyExist(int id);

    }
}
