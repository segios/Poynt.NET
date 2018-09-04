using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class AuthorizationList

    {

        private const string TAG = "AuthorizationList";

        public AuthorizationListType Type { get; set; }

        public IList<System.Guid> Ids { get; set; }

    }
}
