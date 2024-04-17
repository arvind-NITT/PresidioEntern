using DoctorClinicModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorClinicModelLibrary;
namespace DoctorClinicDALLibrary
{
    internal class AppointmentRepo : IRepository<int, Appointment>
    {


        readonly Dictionary<int, Appointment> _Appointments;
        public AppointmentRepo()
        {
            _Appointments = new Dictionary<int, Appointment>();
        }
        int GenerateId()
        {
            if (_Appointments.Count == 0)
                return 1;
            int id = _Appointments.Keys.Max();
            return ++id;
        }
        public Appointment Add(Appointment item)
        {
            if (_Appointments.ContainsValue(item))
            {
                return null;
            }
            _Appointments.Add(GenerateId(), item);
            return item;
        }

        public Appointment Delete(int key)
        {
            if (_Appointments.ContainsKey(key))
            {
                var Appointment = _Appointments[key];
                _Appointments.Remove(key);
                return Appointment;
            }
            return null;
        }

        public Appointment Get(int key)
        {
            return _Appointments.ContainsKey(key) ? _Appointments[key] : null;
        }

        public List<Appointment> GetAll()
        {
            if (_Appointments.Count == 0)
                return null;
            return _Appointments.Values.ToList();
        }

        public Appointment Update(Appointment item)
        {
            if (_Appointments.ContainsKey(item.Id))
            {
                _Appointments[item.Id] = item;
                return item;
            }
            return null;
        }
    }
}
