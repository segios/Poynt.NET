using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class AuthEval

    {

        private const string TAG = "AuthEval";

        public IList<string> Ops { get; set; }

        public string Resource { get; set; }

        public string Status { get; set; }

    }
}
