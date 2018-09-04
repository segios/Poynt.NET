using System;

namespace Poynt.NET.Model
{
	 
	public class ProductSummary
	
	{
	
	private const string TAG = "ProductSummary";
	
	public CurrencyAmount Price { get; set; }
	
	public string Id { get; set; }
	
	public string ShortCode { get; set; }
	
	public string Name { get; set; }
	
	public System.Guid businessId;
	   
    }
}
