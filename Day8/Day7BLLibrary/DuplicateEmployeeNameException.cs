using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7BLLibrary
{
    public class DuplicateEmployeeNameException: Exception
    {
        readonly string msg;
        public DuplicateEmployeeNameException()
        {
            msg = "Employee name already exists";

        }
        public override string Message => msg;
    }
}
