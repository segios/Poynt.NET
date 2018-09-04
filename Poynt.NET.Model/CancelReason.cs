using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
    public enum CancelReason
    {
        TIMEOUT,
        CARD_REMOVED,
        CHIP_DECLINE_AFTER_HOST_APPROVAL,
        PIN_PAD_NOT_AVAILABLE,
        MERCHANT_CANCELLED
    }
}
