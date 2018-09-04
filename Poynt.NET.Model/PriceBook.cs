//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class PriceBook
	
	{
	
	private const string TAG = "PriceBook";
	
	public DateTime StartAt { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public PriceStatus Status { get; set; }
	
	public string Id { get; set; }
	
	public string Name { get; set; }
	
	public string Description { get; set; }
	
	public System.Guid businessId;
	   
    }
}
