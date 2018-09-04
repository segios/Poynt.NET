//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Stats
	
	{
	
	private const string TAG = "Stats";
	
	public IList<Stats> BreakDowns { get; set; }
	
	public IList<StatsItem> Items { get; set; }
	
	public long? BusinessId { get; set; }
	
	public long? StoreId { get; set; }
	
	public long? TerminalId { get; set; }
	
	public long? Date { get; set; }
	
	public StatTimeUnit TimeUnit { get; set; }
	
	public StatsFacet Facet { get; set; }
	
	public StatsLayout Layout { get; set; }
	
	public string BreakDownId { get; set; }
	
	public string Type { get; set; }
	
	public string Label { get; set; }
	
	public string Heading { get; set; }
	   
    }
}
