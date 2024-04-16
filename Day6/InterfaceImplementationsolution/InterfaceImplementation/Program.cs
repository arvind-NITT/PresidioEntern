using CompaniesInterfaceModelLibrary;
namespace InterfaceImplementation
{
    internal class Program
    {
        Employee[] employees;
        public Program()
        {
            employees = new Employee[2];
        }
        void PrintMenu()
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Print Employees");
            Console.WriteLine("0. Exit");
        }
        void EmployeeInteraction()
        {
            int choice = 0;
            do
            {
                PrintMenu();
                Console.WriteLine("Please select an option");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.....");
                        break;
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        PrintAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice != 0);
        }
        void AddEmployee()
        {
            int count = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    count++;
                }
            }
            if (employees.Length == count)
            {
                Console.WriteLine("Sorry we have reached the maximum number of employees");
                return;
            }
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = CreateEmployee(i);
                    break;
                }
            }

        }
        void PrintAllEmployees()
        {

            int count = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                   {
                      PrintEmployee(employees[i]);
                   }
                else count++;
            }
            if (count == employees.Length)
            {
                Console.WriteLine("No Employees available");
                return;

            }
        }
        Employee CreateEmployee(int id)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Your Company Name : ");
            string cmp= Console.ReadLine();
            if (cmp == "Presidio")
            {
                employee = new Presidio();
            }
            else if(cmp == "GenSpark")
            {
                employee = new GenSpark();
            }
            employee.Id = 101 + id;
            employee.BuildEmployeeFromConsole();
            return employee;
        }

        void PrintEmployee(Employee employee)
        {
            Console.WriteLine("---------------------------");
            employee.PrintEmployeeDetails();
            Benefits benefits = new Benefits();
            benefits.BenefitsForEmployee(employee,employee.Salary,employee.JoiningDate);
            Console.WriteLine("---------------------------");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.EmployeeInteraction();
        }
    }
}
