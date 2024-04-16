using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesInterfaceModelLibrary
{
    public interface IGovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double GratuityAmount(float serviceCompleted, double basicSalary);

    }
}
