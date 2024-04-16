using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesInterfaceModelLibrary
{
    public class GenSpark : Employee
    {
        public GenSpark() { }
        public override void BuildEmployeeFromConsole()
        {
            base.BuildEmployeeFromConsole();
        }
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("GenSpark");
            base.PrintEmployeeDetails();
        }
        public override double EmployeePF(double basicSalary)
        {
            return (3.67 * basicSalary) / 100;
        }
        public override string LeaVeDetails()
        {
            return "\nLeave Details for Accenture is "
                 + "\n 2 day of Casual Leave per month\r"
                 + "\n 5 days of Sick Leave per year"
                 + "\n 5 days of Privilege Leave per year";
        }
        public override double GratuityAmount(float serviceCompleted, double basicSalary)
        {
                return 0;
        }
    }
}
