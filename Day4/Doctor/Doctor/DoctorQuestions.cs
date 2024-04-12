using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSolutions
{
    internal class Doctor
    {
        public Doctor()
        {
            int Id = 0;
            string Name = string.Empty;
            int Age = 0;
            string Qualification = string.Empty;
            int Experience = 0;
            string Speciality = string.Empty;
        }

        public Doctor(int id)
        {
            Id = id;
        }

        public Doctor(int id, string name, int age, int experience, string qualification, string speciality) : this(id)
        {
            Name = name;
            Age = age;
            Experience = experience;
            Qualification = qualification;
            Speciality = speciality;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Experience { get; set; }
        public string Qualification { get; set; }
        public string Speciality { get; set; }

        public void PrintDoctorsDetail()
        {
            Console.WriteLine($"Doctors Id       \t:\t {Id}");
            Console.WriteLine($"Doctors Name      \t:\t {Name}");
            Console.WriteLine($"Doctors Age        \t:\t {Age}");
            Console.WriteLine($"Doctors Exp         \t:\t {Experience}");
            Console.WriteLine($"Doctots speciality   \t:\t {Speciality}");
            Console.WriteLine($"Doctots Qualification \t:\t {Qualification}");



        }
    }
}
