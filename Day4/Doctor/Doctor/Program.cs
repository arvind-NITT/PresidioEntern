namespace DoctorSolutions
{
        internal class Program
        {
            Doctor CreateDoctorViaConsole(int id)
            {
                Doctor doctor = new Doctor(id);

                // get name 
                Console.WriteLine("Please enter Doctor's name ");
                doctor.Name = Console.ReadLine();

                // get age
                int age;
                Console.WriteLine("Enter Doctor's age");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("invalid entry , try again");
                }
                doctor.Age = age;

                //get experience
                int experience;
                Console.WriteLine("Enter Doctor's experience");
                while (!int.TryParse(Console.ReadLine(), out experience))
                {
                    Console.WriteLine("invalid entry , try again");
                }
                doctor.Experience = experience;

                // get qualification 
                Console.WriteLine("Please enter doctor's Qualification");
                doctor.Qualification = Console.ReadLine();

                // get Speciality 
                Console.WriteLine("Please enter doctor's Speciality");
                doctor.Speciality = Console.ReadLine();

                return doctor;
            }

            int GetDoctorsCount()
            {
                //current using it because I dont know replacment of VECTOR , that can grow and shrink 
                Console.WriteLine("Please Enter total number of doctors ");
                int count;
                while (!int.TryParse(Console.ReadLine(), out count))
                {
                    Console.WriteLine("invalid entry , try again");
                }
                return count;
            }
            static void Main(string[] args)
            {
                Program program = new Program();
                int count = program.GetDoctorsCount();
                Doctor[] doctors = new Doctor[count];
                for (int i = 0; i < doctors.Length; i++)
                {
                    doctors[i] = program.CreateDoctorViaConsole(100 + i);
                }
                for (int i = 0; i < doctors.Length; i++)
                {
                    doctors[i].PrintDoctorsDetail();
                }

                program.GetDoctorBySpecialization(doctors);
            }

            void GetDoctorBySpecialization(Doctor[] doctors)
            {
                Console.WriteLine("Please enter doctor's Speciality for searching");
                string speciality = Console.ReadLine();
                bool flag = false;

                for (int i = 0; i < doctors.Length; i++)
                {
                    if (doctors[i].Speciality == speciality)
                    {
                        doctors[i].PrintDoctorsDetail();
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Sorry!! There is no such doctor with given Specialization");

                }


            }
        }
    }

