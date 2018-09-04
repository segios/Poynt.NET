using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Order
	
	{
	
	private const string TAG = "Order";
	
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
