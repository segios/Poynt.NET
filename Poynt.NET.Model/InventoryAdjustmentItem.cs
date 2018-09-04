//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class InventoryAdjustmentItem
	
	{
	
	private const string TAG = "InventoryAdjustmentItem";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public CurrencyAmount UnitCost { get; set; }
	
	public long? AdjustCount { get; set; }
	
	public string InvestmentAdjustmentId { get; set; }
	
	public string InventoryId { get; set; }
	   
    }
}
