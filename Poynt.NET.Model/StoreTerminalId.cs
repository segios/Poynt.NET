//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class StoreTerminalId
	
	{
	
	private const string TAG = "StoreTerminalId";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public IDictionary<string, string> Properties { get; set; }
	
	public Processor Acquirer { get; set; }
	
	public string Tid { get; set; }
	
	public string Mid { get; set; }
	
	public string DeviceId { get; set; }
	   
    }
}
