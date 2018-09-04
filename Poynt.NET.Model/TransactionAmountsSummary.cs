//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class TransactionAmountsSummary
	
	{
	
	private const string TAG = "TransactionAmountsSummary";
	
	public int? AuthorizedCount { get; set; }
	
	public int? VoidedCount { get; set; }
	
	public int? CapturedCount { get; set; }
	
	public int? RefundedCount { get; set; }
	
	public int? SavedCount { get; set; }
	
	public TransactionAmounts AuthorizedTotals { get; set; }
	
	public TransactionAmounts VoidedTotals { get; set; }
	
	public TransactionAmounts CapturedTotals { get; set; }
	
	public TransactionAmounts RefundedTotals { get; set; }
	
	public TransactionAmounts SavedTotals { get; set; }
	   
    }
}
