using System;

namespace Poynt.NET.Model
{
	 
	public class OrderItemTax
	
	{
	
	private const string TAG = "OrderItemTax";
	
	public bool? TaxExempted { get; set; }
	
	public bool? CatalogLevel { get; set; }
	
	public long? Amount { get; set; }
	
	public string Id { get; set; }
	
	public string Type { get; set; }
	   
    }
}
