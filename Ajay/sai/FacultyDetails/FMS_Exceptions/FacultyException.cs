using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Exceptions
{
    public class FacultyException : ApplicationException
    {
        public FacultyException() : base()
        { }
        public FacultyException(string exMessage) : base(exMessage)
        { }
        public FacultyException(string exMessage, Exception innerException) : base(exMessage, innerException)
        { }
    }
}
