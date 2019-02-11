using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerMS_Exception
{
    public class ServiceEntryValidationException : Exception
    {
        public ServiceEntryValidationException() : base() { }

        public ServiceEntryValidationException(string Message) : base(Message) { }

        public ServiceEntryValidationException(string Message, Exception innerException) : base(Message, innerException) { }
    }
}
