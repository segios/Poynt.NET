//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Organization
	
	{
	
	private const string TAG = "Organization";
	
	public bool? Distributor { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public IList<UserWithRole> Members { get; set; }
	
	public IDictionary<string, string> Attributes { get; set; }
	
	public string Name { get; set; }
	
	public string Url { get; set; }
	
	public string EmailAddress { get; set; }
	
	public string Description { get; set; }
	
	public System.Guid id;
	   
    }
}
