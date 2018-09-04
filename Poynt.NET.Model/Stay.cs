//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Stay
	
	{
	
	private const string TAG = "Stay";
	
	public bool? TaxExempted { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public ClientContext Context { get; set; }
	
	public IList<Discount> Discounts { get; set; }
	
	public IList<Fee> Fees { get; set; }
	
	public IList<Link> Links { get; set; }
	
	public IList<OrderItem> Items { get; set; }
	
	public IList<Transaction> Transactions { get; set; }
	
	public long? _id { get; set; }
	
	public long? CustomerUserId { get; set; }
	
	public OrderAmounts Amounts { get; set; }
	
	public OrderStatuses Statuses { get; set; }
	
	public StayType StayType { get; set; }
	
	public string OrderNumber { get; set; }
	
	public string Notes { get; set; }
	
	public System.Guid id;
	
	public System.Guid parentId;
	   
    }
}
