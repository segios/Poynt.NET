//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class Inventory
	
	{
	
	private const string TAG = "Inventory";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public float? StockCount { get; set; }
	
	public float? AvailableCount { get; set; }
	
	public float? ReOrderPoint { get; set; }
	
	public float? ReOrderLevel { get; set; }
	
	public System.Guid storeId;
	   
    }
}
