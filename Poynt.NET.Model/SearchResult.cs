//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class SearchResult
	
	{
	
	private const string TAG = "SearchResult";
	
	public bool? Timedout { get; set; }
	
	public DateTime StartAtFilter { get; set; }
	
	public DateTime EndAtFilter { get; set; }
	
	public int? Total { get; set; }
	
	public int? Limit { get; set; }
	
	public IList<SearchHit> Hits { get; set; }
	
	public IList<SearchResourceType> TypeFilter { get; set; }
	
	public string Q { get; set; }
	
	public string DeviceIdFilter { get; set; }
	
	public System.Guid businessIdFilter;
	
	public System.Guid storeIdFilter;
	   
    }
}
