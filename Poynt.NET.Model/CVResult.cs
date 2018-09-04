using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
    public enum CVResult
    {
        MATCH,
        NO_MATCH,
        NOT_PROCESSED,
        NO_CODE_PRESENT,
        SHOULD_HAVE_BEEN_PRESENT,
        ISSUER_NOT_CERTIFIED,
        INVALID,
        NO_RESPONSE,
        NOT_APPLICABLE
    }
}
