using DoctorClinicAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DoctorClinicAPI.Contexts
{
    public class DoctorClinicContext : DbContext
    {
        public DoctorClinicContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Doctor> Doctor { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor() { Id = 101, Name = "Arvind", Specialization="MBBS", Experience=2.0 },
                new Doctor() { Id = 102, Name = "Sunil", Specialization = "Surgen", Experience = 3.0 }
                );
        }
    }
}
