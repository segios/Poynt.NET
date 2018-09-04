using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class InventorySummaryList
	
	{
	
	private const string TAG = "InventorySummaryList";
	
	public IList<InventorySummary> Items { get; set; }
	
	public IList<Link> Links { get; set; }
	   
    }
}
