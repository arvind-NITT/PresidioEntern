using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBLLibrary 
{
    public class BookNotFoundException : Exception
    {
        readonly string msg;
        public BookNotFoundException()
        {
            msg = "Book Not Found ";
        }
        public override string Message => msg;
    }
}
