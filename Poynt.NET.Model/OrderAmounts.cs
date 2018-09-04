//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class OrderAmounts
	
	{
	
	private const string TAG = "OrderAmounts";
	
	public long? SubTotal { get; set; }
	
	public long? DiscountTotal { get; set; }
	
	public long? FeeTotal { get; set; }
	
	public long? TaxTotal { get; set; }
	
	public long? NetTotal { get; set; }
	
	public string Currency { get; set; }
	
	public TransactionAmounts AuthorizedTotals { get; set; }
	
	public TransactionAmounts VoidedTotals { get; set; }
	
	public TransactionAmounts CapturedTotals { get; set; }
	
	public TransactionAmounts RefundedTotals { get; set; }
	
	public TransactionAmounts SavedTotals { get; set; }
	   
    }
}
