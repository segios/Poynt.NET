//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CaptureAllRequest

    {

        private const string TAG = "CaptureAllRequest";

        public AuthorizationList IncludeExcludeList { get; set; }

        public CaptureAllRange Range { get; set; }

        public IList<CaptureRequest> CaptureList { get; set; }

        public long? EmployeeUserId { get; set; }

        public string StoreDeviceId { get; set; }

        public string Tid { get; set; }

        public System.Guid storeId { get; set; }

    }
}
