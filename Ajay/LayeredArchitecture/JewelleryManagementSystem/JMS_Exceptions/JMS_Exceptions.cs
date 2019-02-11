using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class JMS_Exceptions : Exception
    {
       

        public JMS_Exceptions()
          : base()
        {
        }

        public JMS_Exceptions(string message)
            : base(message)
        {
        }
        public JMS_Exceptions(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
