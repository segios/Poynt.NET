using System;

namespace Poynt.NET.Model
{
	 
	public class UserCredential
	
	{
	
	private const string TAG = "UserCredential";
	
	public CredentialType PublicCredentialType { get; set; }
	
	public long? Id { get; set; }
	
	public string PublicCredentialValue { get; set; }
	
	public string PrivateCredentialValue { get; set; }
	
	public string PrivateCredentialSalt { get; set; }
	   
    }
}
