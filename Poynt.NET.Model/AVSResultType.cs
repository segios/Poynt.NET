using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
    public enum AVSResultType
    {
        MATCH,
        NO_MATCH,
        PARTIAL_MATCH,
        NOT_PROVIDED,
        ISSUER_NOT_CERTIFIED,
        NO_RESPONSE_FROM_CARD_ASSOCIATION,
        UNKNOWN_RESPONSE_FROM_CARD_ASSOCIATION,
        NOT_VERIFIED,
        BAD_FORMAT,
        ERROR,
        UNSUPPORTED_BY_ISSUER,
        UNAVAILABLE
    }
}
