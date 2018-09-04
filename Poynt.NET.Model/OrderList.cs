using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class OrderList
	
	{
	
	private const string TAG = "OrderList";
	
	public IList<Link> Links { get; set; }
	
	public IList<Order> Orders { get; set; }
	
	public long? Count { get; set; }
	   
    }
}
