using DoctorClinicAPI.Models;

namespace DoctorClinicAPI.Interfaces
{
    public interface IDoctorService
    {
        public Task<IEnumerable<Doctor>> GetDoctorBySpeciality(string Speciality);
       // public Task<Doctor> GetDoctorByName(string name);
        public Task<Doctor> UpdateDoctorExperience(int id, double Experience);
        public Task<IEnumerable<Doctor>> GetDoctors();

    }
}
