using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class TaxList
	
	{
	
	private const string TAG = "TaxList";
	
	public IList<Link> Links { get; set; }
	
	public IList<Tax> Taxes { get; set; }
	   
    }
}
