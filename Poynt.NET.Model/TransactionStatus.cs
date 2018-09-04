using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
    public enum TransactionStatus
    {
        CREATED,
        SAVED,
        AUTHORIZED,
        PARTIALLY_CAPTURED,
        CAPTURED,
        DECLINED,
        PARTIALLY_CAPTURED_AND_PARTIALLY_REFUNDED,
        PARTIALLY_REFUNDED,
        REFUNDED,
        VOIDED
    }
}
