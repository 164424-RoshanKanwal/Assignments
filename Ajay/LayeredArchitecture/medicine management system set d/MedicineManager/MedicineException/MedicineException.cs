using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineException
{
    //creating custom exception class for medicineManager inheriting from ApplicationException
    public class MedicineException :ApplicationException
    {

        public MedicineException() : base() { }
        public MedicineException(string message) : base(message) { }
        public MedicineException(string message, Exception innerException) : base(message, innerException) { }
    }
}
