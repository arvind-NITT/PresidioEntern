﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorClinicModelLibrary;

namespace DoctorClinicDALLibrary
{
    internal class DoctorRepo : IRepository<int, Doctor>
    {
        readonly Dictionary<int, Doctor> _Doctors;
        public DoctorRepo()
        {
            _Doctors = new Dictionary<int, Doctor>();
        }
        int GenerateId()
        {
            if (_Doctors.Count == 0)
                return 1;
            int id = _Doctors.Keys.Max();
            return ++id;
        }
        public Doctor Add(Doctor item)
        {
            if (_Doctors.ContainsValue(item))
            {
                return null;
            }
            _Doctors.Add(GenerateId(), item);
            return item;
        }

        public Doctor Delete(int key)
        {
            if (_Doctors.ContainsKey(key))
            {
                var Doctor = _Doctors[key];
                _Doctors.Remove(key);
                return Doctor;
            }
            return null;
        }

        public Doctor Get(int key)
        {
            return _Doctors.ContainsKey(key) ? _Doctors[key] : null;
        }

        public List<Doctor> GetAll()
        {
            if (_Doctors.Count == 0)
                return null;
            return _Doctors.Values.ToList();
        }

        public Doctor Update(Doctor item)
        {
            if (_Doctors.ContainsKey(item.Id))
            {
                _Doctors[item.Id] = item;
                return item;
            }
            return null;
        }
     

    }
}
