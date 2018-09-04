using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class StayList
	
	{
	
	private const string TAG = "StayList";
	
	public IList<Link> Links { get; set; }
	
	public IList<Stay> Stays { get; set; }
	
	public long? Count { get; set; }
	   
    }
}
