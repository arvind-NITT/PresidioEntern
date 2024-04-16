using CompaniesInterfaceModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    public class Benefits
    {
        public void BenefitsForEmployee(IGovtRules govtRules,double salary,DateTime JoiningDate)
        {
            double Pf = govtRules.EmployeePF(salary);
            string LDetails = govtRules.LeaVeDetails();
            int year = ((DateTime.Today - JoiningDate).Days) / 365;
            double Gratuity = govtRules.GratuityAmount(year, salary);
            Console.WriteLine("Employee PF : " + Pf);
            Console.WriteLine("Employee Leave Details : " + LDetails);
            Console.WriteLine("Employee GratuityAmount : " + Gratuity);
        }
    }
}
