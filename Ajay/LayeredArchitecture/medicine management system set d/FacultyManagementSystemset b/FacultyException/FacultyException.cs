using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyException
{
    public class FacultyException:ApplicationException
    {
        public FacultyException() : base() { }
        public FacultyException(string message) : base(message) { }
        public FacultyException(string message, Exception innerException) : base(message, innerException) { }
    }
}
