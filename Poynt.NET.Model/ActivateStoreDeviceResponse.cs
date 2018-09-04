using System;

namespace Poynt.NET.Model
{

    public class ActivateStoreDeviceResponse

    {

        private const string TAG = "ActivateStoreDeviceResponse";

        public bool? AlreadyActivated { get; set; }

        public string EmailSignupCode { get; set; }

    }
}
