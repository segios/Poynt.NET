using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public enum ProcessorFeature
    {
        REFERENCED_REFUND,
        REFERENCED_REFUND_FOR_PINDEBIT,
        AUTHORIZE_FOR_PINDEBIT,
        VOICE_AUTHORIZATION,
        SALE_ADJUSTMENT,
        EBT,
        HSA,
        EMV,
        CONTACTLESS,
        PARTIAL_APPROVAL,
        REMAINING_BALANCE,
        VOID_WITHOUT_TXN_ID,
        VOID_AUTH,
        VOID_SALE,
        VOID_SALE_FOR_PINDEBIT,
        VOID_REFUND,
        VOID_CAPTURE,
        SEARCH_TRANSACTION,
        VERIFY
    }
}
