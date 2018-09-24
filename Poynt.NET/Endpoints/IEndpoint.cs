using System;
using System.Collections.Generic;
using System.Text;

namespace Poynt.NET.Endpoints
{
    public interface IEndpoint
    {
        string Endpoint { get; set; }
        IEndpoint ParentEndpoint { get; set; }

        string Resolve(params string[] parents);
    }
  
}
