using System;

namespace Poynt.NET.Model
{
	 
	public class PublicKeyRegistration
	
	{
	
	private const string TAG = "PublicKeyRegistration";
	
	public PublicKeyVerificationData VerificationData { get; set; }
	
	public string PublicKey { get; set; }
	
	public string SerialNumber { get; set; }
	   
    }
}
