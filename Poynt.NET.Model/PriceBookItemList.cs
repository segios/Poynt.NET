using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class PriceBookItemList
	
	{
	
	private const string TAG = "PriceBookItemList";
	
	public IList<Link> Links { get; set; }
	
	public IList<PriceBookItem> Items { get; set; }
	   
    }
}
