using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppModelLibrary.Exceptions
{
    public class NoCartItemWithGiveIdException : Exception
    {
        string message;
        public NoCartItemWithGiveIdException()
        {
            message = "CartItem with the given Id is not present";
        }
        public override string Message => message;
    }
}
