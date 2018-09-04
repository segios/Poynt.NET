using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class ProductSummaryList
	
	{
	
	private const string TAG = "ProductSummaryList";
	
	public IList<Link> Links { get; set; }
	
	public IList<ProductSummary> Products { get; set; }
	   
    }
}
