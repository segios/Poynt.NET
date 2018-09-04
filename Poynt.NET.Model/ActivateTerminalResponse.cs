using System;

namespace Poynt.NET.Model
{
    public class ActivateTerminalResponse

    {

        private const string TAG = "ActivateTerminalResponse";

        public bool? UsingExistingCredentials { get; set; }

        public bool? AlreadyActivated { get; set; }

        public TokenResponse TokenResponse { get; set; }

    }
}
