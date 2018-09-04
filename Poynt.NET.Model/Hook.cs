
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Hook
	
	{
	
	private const string TAG = "Hook";
	
	public bool? Active { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public IList<string> EventTypes { get; set; }
	
	public string Id { get; set; }
	
	public string ApplicationId { get; set; }
	
	public string Secret { get; set; }
	
	public string DeliveryUrl { get; set; }
	
	public System.Guid businessId;
	   
    }
}
