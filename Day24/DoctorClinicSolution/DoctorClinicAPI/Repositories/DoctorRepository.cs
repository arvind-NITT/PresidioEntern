using DoctorClinicAPI.Contexts;
using DoctorClinicAPI.Exceptions;
using DoctorClinicAPI.Interfaces;
using DoctorClinicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorClinicAPI.Repositories
{
    public class DoctorRepository : IRepository<int, Doctor>
    {
        private readonly DoctorClinicContext _context;
        public DoctorRepository(DoctorClinicContext context)
        {
            _context = context;
        }
        public async Task<Doctor> Add(Doctor item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Doctor> Delete(int key)
        {
            var Doctor = await Get(key);
            if (Doctor != null)
            {
                _context.Remove(Doctor);
                _context.SaveChangesAsync(true);
                return Doctor;
            }
            throw new NoSuchdoctorsException();
        }

        public Task<Doctor> Get(int key)
        {
            var Doctor = _context.Doctor.FirstOrDefaultAsync(e => e.Id == key);
            return Doctor;
        }

        public async Task<IEnumerable<Doctor>> Get()
        {
            var Doctors = await _context.Doctor.ToListAsync();
            return Doctors;

        }

        public async Task<Doctor> Update(Doctor item)
        {
            var Doctor = await Get(item.Id);
            if (Doctor != null)
            {
                _context.Update(item);
                _context.SaveChangesAsync(true);
                return Doctor;
            }
            throw new NoSuchdoctorsException();
        }
    }
}
