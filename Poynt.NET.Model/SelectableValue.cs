using System;

namespace Poynt.NET.Model
{
	 
	public class SelectableValue
	
	{
	
	private const string TAG = "SelectableValue";
	
	public bool? DefaultValue { get; set; }
	
	public CurrencyAmount PriceDelta { get; set; }
	
	public string Name { get; set; }
	   
    }
}
