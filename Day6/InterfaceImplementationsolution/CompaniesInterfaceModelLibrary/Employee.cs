namespace CompaniesInterfaceModelLibrary
{
    public class Employee : IGovtRules
    {
        public int Id { get; set; }
        
        public DateTime JoiningDate;
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }


        public Employee()
        {
            Id =0;
            Name = string.Empty;
            Department = string.Empty;
            Designation = string.Empty;
            Salary = 0.0;

        }

        public Employee(int id, string name, string department, string designation, double salary, DateTime joiningDate)
        {
            Id = id;
            Name = name;
            Department = department;
            Designation = designation;
            Salary = salary;
            JoiningDate = joiningDate;
        }
        public virtual void BuildEmployeeFromConsole()
        {
            Console.WriteLine("Please enter the Name");
            Name = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Please enter the Department");
            Department = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Please enter the Designation");
            Designation = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Please enter the Joining Date");
            JoiningDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter the Basic Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id : " + Id);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Date of birth : " + JoiningDate);
            Console.WriteLine("Employee Salary : Rs." + Salary);
            Console.WriteLine("Employee Department : " + Department);
            Console.WriteLine("Employee Designation : " + Designation);
        }
        public virtual double EmployeePF(double basicSalary)
        {
            return 0;
        }
        public virtual string LeaVeDetails()
        {
           return "";
        }
        public virtual double GratuityAmount(float serviceCompleted, double basicSalary)
        {
                return 0;
        }

    }
}
