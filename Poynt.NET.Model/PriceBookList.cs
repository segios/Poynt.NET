using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class PriceBookList
	
	{
	
	private const string TAG = "PriceBookList";
	
	public IList<Link> Links { get; set; }
	
	public IList<PriceBook> PriceBooks { get; set; }
	   
    }
}
