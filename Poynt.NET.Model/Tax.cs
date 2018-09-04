//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class Tax
	
	{
	
	private const string TAG = "Tax";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public double? Rate { get; set; }
	
	public long? Amount { get; set; }
	
	public string Id { get; set; }
	
	public string Name { get; set; }
	
	public string Description { get; set; }
	
	public string Type { get; set; }
	
	public System.Guid businessId;
	   
    }
}
