using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelException
{
    class WorkerValidationException : Exception
    {
        public WorkerValidationException(string ErrorMessage)   : base (ErrorMessage)
        {
            Console.WriteLine("error message worker validation error");
        }
    }
}
