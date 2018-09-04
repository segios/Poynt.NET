using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Intent
	
	{
	
	private const string TAG = "Intent";
	
	public IDictionary<string, IntentExtra> Extras { get; set; }
	
	public string PackageName { get; set; }
	
	public string ClassName { get; set; }
	
	public string Action { get; set; }
	   
    }
}
