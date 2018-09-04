using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DeviceCommand

    {

        private const string TAG = "DeviceCommand";

        public DeviceType DeviceType { get; set; }

        public IList<DeviceMacAddress> MacAddresses { get; set; }

        public long? Id { get; set; }

    }
}
