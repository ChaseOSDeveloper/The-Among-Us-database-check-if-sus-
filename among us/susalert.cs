using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace among_us
{
    public class SusException : Exception
    {
        public SusException(string message)

            : base(message)
        { }
        protected SusException(SerializationInfo info, StreamingContext ctxt)
    : base(info, ctxt)
        { }
    }
}
