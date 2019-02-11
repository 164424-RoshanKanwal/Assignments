using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentException
{
    //creating custom exception for handling the exceptions
    public class StudentException: ApplicationException
    {
        public StudentException() : base() { }

        public StudentException(string message) : base(message) { }

        public StudentException(string message, Exception innerException) : base(message, innerException) { }
    }
}
