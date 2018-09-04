using System;

namespace Poynt.NET.Model
{
	 
	public class OrderStatuses
	
	{
	
	private const string TAG = "OrderStatuses";
	
	public FulfillmentStatus FulfillmentStatus { get; set; }
	
	public OrderStatus Status = OrderStatus.OPENED;
	
	public TransactionStatusSummary TransactionStatusSummary { get; set; }
	   
    }
}
