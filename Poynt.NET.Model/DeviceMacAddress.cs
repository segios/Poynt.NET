using System;

namespace Poynt.NET.Model
{

    public class DeviceMacAddress

    {

        private const string TAG = "DeviceMacAddress";

        public long? Id { get; set; }

        public NetworkInterfaceType NetworkInterface { get; set; }

        public string MacAddress { get; set; }

    }
}
