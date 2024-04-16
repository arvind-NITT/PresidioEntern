using RequestTrackerModelLibrary;

namespace RequestTrackerApp
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
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee by ID");
                Console.WriteLine("5. Delete Employee by ID");
                Console.WriteLine("0. Exit");
            }
            void PrintMenuForUpdate()
            {
                Console.WriteLine("1.Update Name");
                Console.WriteLine("2.Update DOB");
                Console.WriteLine("3.Update Salary");
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
                        case 3:
                            SearchAndPrintEmployee();
                            break;
                        case 4:
                            SearchAndUpdateEmployee();
                            break;
                        case 5:
                            DeleteEmployeeById();
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
                        PrintEmployee(employees[i]);
                    else count++;
                }
                if(count == employees.Length)
            {
                    Console.WriteLine("No Employees available");
                    return;
                
            }
            }
            Employee CreateEmployee(int id)
            {
                Employee employee = new Employee();
                employee.Id = 101 + id;
                employee.BuildEmployeeFromConsole();
                return employee;
            }

            void PrintEmployee(Employee employee)
            {
                Console.WriteLine("---------------------------");
                employee.PrintEmployeeDetails();
                Console.WriteLine("---------------------------");
            }
            int GetIdFromConsole()
            {
                int id = 0;
                Console.WriteLine("Please enter the employee Id");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid entry. Please try again");
                }
                return id;
            }
            void SearchAndPrintEmployee()
            {
                Console.WriteLine("Print One employee");
                int id = GetIdFromConsole();
                Employee employee = SearchEmployeeById(id);
                if (employee == null)
                {
                    Console.WriteLine("No such Employee is present");
                    return;
                }
                PrintEmployee(employee);
                //UpdateEmployeeName(employee);

            }
            void UpdateEmployeeName(Employee employee)
            {
                Console.WriteLine("Enter the Updated Name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Details of Updated Employee");
                PrintEmployee(employee);
                Console.WriteLine("Update Successfull");
            }
          
            void UpdateEmployeeDob(Employee employee)
            {
                Console.WriteLine("Enter the Updated DOB");
                employee.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Details of Updated Employee");
                PrintEmployee(employee);
                Console.WriteLine("Update Successfull");
            }
            void UpdateEmployeeSalary(Employee employee)
            {
                Console.WriteLine("Enter the Updated Salary");
                employee.Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Details of Updated Employee");
                PrintEmployee(employee);
                Console.WriteLine("Update Successfull");
            }
            void SearchAndUpdateEmployee()
            {
                int id = GetIdFromConsole();
                Employee employee = SearchEmployeeById(id);
                if (employee == null)
                {
                    Console.WriteLine("Sorry No Employee with the matching Id found");
                    return;
                }
                PrintEmployee(employee);
                PrintMenuForUpdate();
                Console.WriteLine("Please select an option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.....");
                        break;
                    case 1:
                        UpdateEmployeeName(employee);
                        break;
                    case 2:
                        UpdateEmployeeDob(employee);
                        break;
                    case 3:
                        UpdateEmployeeSalary(employee);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
               
                //UpdateEmployeeName(employee);
            }
            void DeleteEmployee(Employee employee)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] != null && employees[i].Id == employee.Id)
                    {
                        employees[i] = null;
                        Console.WriteLine("Deleted Successfully");
                        break;
                    }
                }
            }
            void DeleteEmployeeById()
            {
                int id = GetIdFromConsole();
                Employee employee = SearchEmployeeById(id);
                if (employee == null)
                {
                    Console.WriteLine("Sorry No Employee exist with the Matching Id");
                    return;
                }
                PrintEmployee(employee);
                DeleteEmployee(employee);
            }
            Employee SearchEmployeeById(int id)
            {
                Employee employee = null;
                for (int i = 0; i < employees.Length; i++)
                {
                    // if ( employees[i].Id == id && employees[i] != null)//Will lead to exception
                    if (employees[i] != null && employees[i].Id == id)
                    {
                        employee = employees[i];
                        break;
                    }
                }
                return employee;
            }

            static void Main(string[] args)
            {
                Program program = new Program();
                program.EmployeeInteraction();
            }
        }
    
}
