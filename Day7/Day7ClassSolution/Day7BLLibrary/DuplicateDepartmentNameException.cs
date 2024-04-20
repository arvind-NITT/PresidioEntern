using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7BLLibrary
{
    public class DuplicateDepartmentNameException :Exception
    {
        string msg;
      public DuplicateDepartmentNameException()
        {

            msg = "Department Name already Exist";
        }
        public override string Message => msg;
    }
}
