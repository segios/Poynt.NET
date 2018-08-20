using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Exceptions
{
    public class PoyntSDKException : Exception
    {
        public string Code { get; set; }
        public PoyntSDKException() { }
        public PoyntSDKException(string msg) : base(msg) { }
        public PoyntSDKException(string msg, Exception innerException) : base(msg, innerException) { }
    }
}
