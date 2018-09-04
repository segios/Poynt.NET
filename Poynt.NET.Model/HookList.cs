using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class HookList
	
	{
	
	private const string TAG = "HookList";
	
	public IList<Hook> Hooks { get; set; }
	
	public IList<Link> Links { get; set; }
	   
    }
}
