using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab__6
{
    class Exceptions:Exception
    {
        public Exceptions(String message)
        : base(message)
        {
            
        }
    }
}
