//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class LoyaltyCustomer
	
	{
	
	private const string TAG = "LoyaltyCustomer";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public long? _id { get; set; }
	
	public IDictionary<IdType, string> Identifiers { get; set; }
	
	public ProviderVerification ProviderVerification { get; set; }
	
	public string Id { get; set; }
	
	public string Provider { get; set; }
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public System.Guid businessId;
	   
    }
}
