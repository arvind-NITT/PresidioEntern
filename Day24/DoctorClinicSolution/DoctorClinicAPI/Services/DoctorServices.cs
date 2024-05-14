using DoctorClinicAPI.Exceptions;
using DoctorClinicAPI.Interfaces;
using DoctorClinicAPI.Models;

namespace DoctorClinicAPI.Services
{
    public class DoctorServices : IDoctorService
    {
        private readonly IRepository<int, Doctor> _repository;
        public DoctorServices(IRepository<int, Doctor> reposiroty)
        {
            _repository = reposiroty;
        }
        public async Task<IEnumerable<Doctor>> GetDoctorBySpeciality(string Speciality)
        {
            var doctors = await _repository.Get();
            var filteredDoctors = doctors.Where(d => d.Specialization.Equals(Speciality, StringComparison.OrdinalIgnoreCase));

            if (!filteredDoctors.Any())
                throw new NoDoctorFoundException();

            return filteredDoctors;
        }

        public  async Task<IEnumerable<Doctor>> GetDoctors()
        {
            var doctors = await _repository.Get();
            if (doctors.Count() == 0)
                throw new NoDoctorFoundException();
            return doctors;
        }

        public async  Task<Doctor> UpdateDoctorExperience(int id, double Experience)
        {
            var doctors = await _repository.Get(id);
            if (doctors == null)
                throw new NoSuchdoctorsException();
            doctors.Experience = Experience;
            doctors = await _repository.Update(doctors);
            return doctors;
        }
    }
}
