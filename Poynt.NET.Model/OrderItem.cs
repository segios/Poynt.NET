//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class OrderItem
	
	{
	
	private const string TAG = "OrderItem";
	
	public bool? TaxExempted { get; set; }
	
	public DateTime ServiceStartAt { get; set; }
	
	public DateTime ServiceEndAt { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public float? Quantity { get; set; }
	
	public FulfillmentInstruction FulfillmentInstruction { get; set; }
	
	public int? Id { get; set; }
	
	public IList<Discount> Discounts { get; set; }
	
	public IList<Fee> Fees { get; set; }
	
	public IList<OrderItemTax> Taxes { get; set; }
	
	public IList<Variant> SelectedVariants { get; set; }
	
	public long? _id { get; set; }
	
	public long? UnitPrice { get; set; }
	
	public long? Discount { get; set; }
	
	public long? Fee { get; set; }
	
	public long? Tax { get; set; }
	
	public OrderItemStatus Status { get; set; }
	
	public string Name { get; set; }
	
	public string ProductId { get; set; }
	
	public string Sku { get; set; }
	
	public string ClientNotes { get; set; }
	
	public string Details { get; set; }
	
	public UnitOfMeasure UnitOfMeasure { get; set; }
	   
    }
}
