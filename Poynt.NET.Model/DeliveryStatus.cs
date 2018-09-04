using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public enum DeliveryStatus
    {
        SCHEDULED,
        RESCHEDULED,
        ERRORED_RETRYING,
        DELIVERED,
        ERRORED
    }
}
