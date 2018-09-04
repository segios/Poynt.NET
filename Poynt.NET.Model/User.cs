//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class User
	
	{
	
	private const string TAG = "User";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public IList<Business> Businesses { get; set; }
	
	public IList<OrganizationWithRole> Organizations { get; set; }
	
	public long? Id { get; set; }
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public string MiddleName { get; set; }
	
	public UserCredential Credential { get; set; }
	   
    }
}
