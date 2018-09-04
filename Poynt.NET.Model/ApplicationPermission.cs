using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public class ApplicationPermission

    {

        private const string TAG = "ApplicationPermission";

        public IList<string> Actions { get; set; }

        public string Resource { get; set; }

    }
}
