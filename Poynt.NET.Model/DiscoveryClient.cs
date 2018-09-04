using System;

namespace Poynt.NET.Model
{

    public class DiscoveryClient

    {

        private const string TAG = "DiscoveryClient";

        public string Serial { get; set; }

        public string DeviceId { get; set; }

        public string Build { get; set; }

        public string Agent { get; set; }

        public string AgentVersion { get; set; }

        public string GpsLocation { get; set; }

        public string BuildType { get; set; }

        public string KeyState { get; set; }

        public string TamperState { get; set; }

    }
}
