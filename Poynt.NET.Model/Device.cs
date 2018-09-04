using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class Device

    {

        private const string TAG = "Device";

        public DeviceType DeviceType { get; set; }

        public IList<DeviceMacAddress> MacAddresses { get; set; }

        public long? Id { get; set; }

    }
}
