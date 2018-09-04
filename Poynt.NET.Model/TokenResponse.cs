using System;

namespace Poynt.NET.Model
{
	 
	public class TokenResponse
	
	{
	
	private const string TAG = "TokenResponse";
	
	public long? ExpiresIn { get; set; }
	
	public string AccessToken { get; set; }
	
	public string RefreshToken { get; set; }
	
	public string Scope { get; set; }
	
	public TokenType TokenType { get; set; }
	   
    }
}
