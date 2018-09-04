using System;

namespace Poynt.NET.Model
{
	 
	public class OrderReturn
	
	{
	
	private const string TAG = "OrderReturn";
	
	public bool? Partial { get; set; }
	
	public Order ReturnOrder { get; set; }
	   
    }
}
