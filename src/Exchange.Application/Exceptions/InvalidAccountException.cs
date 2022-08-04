using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Application.Exceptions
{
    public class InvalidAccountException : Exception
    {
        public InvalidAccountException() { }

        public InvalidAccountException(int AccountNumber)
            : base(String.Format("Invalid Account Number: {0}", AccountNumber))
        {

        }
    }
}
