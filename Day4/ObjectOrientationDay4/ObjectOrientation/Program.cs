using ObjectOrientationDay4.Models;

namespace ObjectOrientation

{
    class Program
    {
        Employee CreateEmployeeByTakingDetailsFromConsole(int id)
        {
            Employee employee = new Employee(id);
            Console.WriteLine("Please enter the emplyee name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Date of Birth");
            employee.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            double salary;
            while (!double.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }
            employee.Salary = salary;
            Console.WriteLine("Please enter the employee email");
            employee.Email = Console.ReadLine();
            return employee;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Employee[] employees = new Employee[3];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = program.CreateEmployeeByTakingDetailsFromConsole(101 + i);
            }
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeDetails();
            }
        }
    }
}
