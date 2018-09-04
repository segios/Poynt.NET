//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Terminal
	
	{
	
	private const string TAG = "Terminal";
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public IList<TerminalId> TerminalIds { get; set; }
	
	public string Serial { get; set; }
	
	public string DeviceId { get; set; }
	
	public string Name { get; set; }
	
	public string PublicKey { get; set; }
	
	public string CatalogId { get; set; }
	   
    }
}
