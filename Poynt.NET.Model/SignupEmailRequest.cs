//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class SignupEmailRequest
	
	{
	
	private const string TAG = "SignupEmailRequest";
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public string Email { get; set; }
	
	public string SignupCode { get; set; }
	
	public System.Guid businessId;
	
	public System.Guid organizationId;
	
	public UserRole OrganizationRole { get; set; }
	   
    }
}
