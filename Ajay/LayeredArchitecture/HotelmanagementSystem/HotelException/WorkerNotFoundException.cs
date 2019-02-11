using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelException
{
    public class WorkerNotFoundException : Exception
    {
        public WorkerNotFoundException(string ErrorMessage)     : base (ErrorMessage)
        {
            Console.WriteLine("error mesage  worker not found");
        }



    }
}
