using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesInterfaceModelLibrary
{
    public class Presidio : Employee
    {
        public Presidio() { }
        public override void BuildEmployeeFromConsole()
        {
            base.BuildEmployeeFromConsole();
        }
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("Presidio Company");
            base.PrintEmployeeDetails();
        }
        public override double EmployeePF(double basicSalary)
        {
            return (12 * basicSalary) / 100;
        }
        public override string LeaVeDetails()
        {
            return "\nLeave Details for CTS is "
                 + "\n1 day of Casual Leave per month\r"
                 + "\n12 days of Sick Leave per year"
                 + "\n10 days of Privilege Leave per year";
        }
        public override double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
            {
                return 3 * basicSalary;
            }
            else if (serviceCompleted > 10)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted > 5)
            {
                return basicSalary;

            }
            else
            {
                return 0;
            }
        }
    }
}
