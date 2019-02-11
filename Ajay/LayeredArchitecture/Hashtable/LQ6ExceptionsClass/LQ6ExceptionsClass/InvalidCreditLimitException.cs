using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ6ExceptionsClass
{
    class InvalidCreditLimitException : ApplicationException
    {
        //public GuestPhoneBookException()
        //   : base()
        //{
        //}

        public InvalidCreditLimitException() : base(String.Format("Invalid credit limits:")) {

        }

        public InvalidCreditLimitException(int id) : base(String.Format($"Invalid product Id:{id}"))
        {
           
        }
        public InvalidCreditLimitException(string id) : base(String.Format($"Invalid product name:{id}"))
        {

        }
        public InvalidCreditLimitException(double id) : base(String.Format($"Invalid product price:{id}"))
        {

        }
    }
}
