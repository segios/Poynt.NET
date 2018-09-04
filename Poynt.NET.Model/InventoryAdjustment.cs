//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class InventoryAdjustment
	
	{
	
	private const string TAG = "InventoryAdjustment";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public InventoryAdjustmentStatus Status { get; set; }
	
	public StockAdjustmentType Type { get; set; }
	
	public string Id { get; set; }
	
	public string Name { get; set; }
	   
    }
}
