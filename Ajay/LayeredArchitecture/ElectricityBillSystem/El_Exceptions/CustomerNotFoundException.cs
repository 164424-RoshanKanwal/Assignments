﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Exceptions
{
    public class CustomerNotFoundException :Exception
    {
      
            public CustomerNotFoundException(string errorMessage)
                : base(errorMessage)
            {

            }
      
    }
}
