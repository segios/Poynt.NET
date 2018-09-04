//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class ExchangeRate
	
	{
	
	private const string TAG = "ExchangeRate";
	
	public DateTime RequestedAt { get; set; }
	
	public long? Rate { get; set; }
	
	public long? RatePrecision { get; set; }
	
	public long? CardAmount { get; set; }
	
	public long? TxnAmount { get; set; }
	
	public string CardCurrency { get; set; }
	
	public string TxnCurrency { get; set; }
	
	public string Provider { get; set; }
	
	public string MarkupPercentage { get; set; }
	
	public string Signature { get; set; }
	
	public System.Guid businessId;
	   
    }
}
