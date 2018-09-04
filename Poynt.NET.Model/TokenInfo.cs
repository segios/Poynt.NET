using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class TokenInfo
	
	{
	
	private const string TAG = "TokenInfo";
	
	public IList<AuthEval> Authorized { get; set; }
	
	public IDictionary<string, object> JwtClaims { get; set; }
	
	public System.Guid forBusinessId;
	   
    }
}
