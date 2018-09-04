//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class InventorySummary
	
	{
	
	private const string TAG = "InventorySummary";
	
	public float? StockCount { get; set; }
	
	public float? AvailableCount { get; set; }
	
	public float? ReOrderPoint { get; set; }
	
	public float? ReOrderLevel { get; set; }
	
	public string ProductId { get; set; }
	
	public string ProductName { get; set; }
	
	public string ProductShortCode { get; set; }
	
	public string Sku { get; set; }
	
	public System.Guid storeId;
	   
    }
}
