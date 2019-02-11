using System;
using System.Runtime.Serialization;

namespace LQ9Dictionary
{
    [Serializable]
    internal class ContainingException : Exception
    {
        public ContainingException()
        {
            
        }

        public ContainingException(string message) : base(message)
        {
        }

        public ContainingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ContainingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}