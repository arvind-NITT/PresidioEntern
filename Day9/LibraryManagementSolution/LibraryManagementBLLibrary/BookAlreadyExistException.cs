using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBLLibrary
{
    public class BookAlreadyExistException : Exception
    {
        readonly string msg;
        public BookAlreadyExistException()
        {
            msg = "Book Already Exist ";
        }
        public override string Message => msg;
    }
}
