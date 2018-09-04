using System;

namespace Poynt.NET.Model
{

    public class CancelRequest

    {

        private const string TAG = "CancelRequest";

        public CancelReason CancelReason { get; set; }

        public EMVData EmvData { get; set; }
    }
}
