using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class SelectableVariation
	
	{
	
	private const string TAG = "SelectableVariation";
	
	public IList<SelectableValue> Values { get; set; }
	
	public string Attribute { get; set; }
	
	public string Cardinality { get; set; }
	   
    }
}
