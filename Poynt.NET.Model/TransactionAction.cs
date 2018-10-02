using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
    public enum TransactionAction
    {
        AUTHORIZE,
        CAPTURE,
        VOID,
        OFFLINE_AUTHORIZE,
        REFUND,
        SALE,
        VERIFY
    }
}
