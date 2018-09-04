//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class PriceBookItem
	
	{
	
	private const string TAG = "PriceBookItem";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public CurrencyAmount ListPrice { get; set; }
	
	public CurrencyAmount SalesPrice { get; set; }
	
	public PriceStatus Status { get; set; }
	
	public string Id { get; set; }
	
	public string PriceBookId { get; set; }
	
	public string ProductId { get; set; }
	   
    }
}
