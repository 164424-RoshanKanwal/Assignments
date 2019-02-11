using System;

namespace DTHExceptions
{
    public class ExceptionDTH:ApplicationException
    {
        //Default Constructor , that inherits the base constructor
        public ExceptionDTH() : base() { }

        // Parameterized constructor for passing the Error/Exception Message
        public ExceptionDTH(string Message) :
            base(Message)
        { }
    }
}
