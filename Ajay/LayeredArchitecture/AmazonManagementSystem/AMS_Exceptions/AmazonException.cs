using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_Exceptions
{
    public class AmazonException: Exception
    {
        public AmazonException() : base()

        {

        }

        public AmazonException(string Message) : base(Message)

        {

        }

        public AmazonException(string Message, Exception innerException) : base(Message, innerException)

        {

        }
    }
}
