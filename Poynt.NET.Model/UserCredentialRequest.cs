using System;

namespace Poynt.NET.Model
{
	 
	public class UserCredentialRequest
	
	{
	
	private const string TAG = "UserCredentialRequest";
	
	public CredentialType PublicCredentialType { get; set; }
	
	public string OldPublicCredentialValue { get; set; }
	
	public string OldPrivateCredentialValue { get; set; }
	
	public string NewPublicCredentialValue { get; set; }
	
	public string NewPrivateCredentialValue { get; set; }
	   
    }
}
