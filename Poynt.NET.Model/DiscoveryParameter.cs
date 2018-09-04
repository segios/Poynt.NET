using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public enum DiscoveryParameter
    {
        HTTP_CONNECTION_TIMEOUT,
        HTTP_READ_TIMEOUT,
        SYNC_HTTP_READ_TIMEOUT,
        SYNC_TXN_LIMIT,
        SYNC_ORDER_LIMIT,
        SYNC_TXN_ORDER_FREQUENCY,
        SYNC_CATALOG_FREQUENCY,
        PAYMENT_PROCESSOR,
        PAYMENT_MERCHANT_ID,
        PAYMENT_TERMINAL_ID,
        PAYMENT_AUTO_CAPTURE,
        PAYMENT_TIPS_ENABLED,
        BUSINESS_ID,
        STORE_ID,
        CATALOG_ID
    }
}
