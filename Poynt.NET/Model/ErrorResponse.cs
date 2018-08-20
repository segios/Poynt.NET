using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class ErrorResponse
    {
        public string Code { get; set; }
        public int HttpStatus { get; set; }
        public string Message { get; set; }
        public string DeveloperMessage { get; set; }
    }

}
