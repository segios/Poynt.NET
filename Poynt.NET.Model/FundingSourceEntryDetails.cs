using System;

namespace Poynt.NET.Model
{
	 
	public class FundingSourceEntryDetails
	
	{
	
	private const string TAG = "FundingSourceEntryDetails";
	
	public bool? IccFallback { get; set; }
	
	public CustomerPresenceStatus CustomerPresenceStatus { get; set; }
	
	public EntryMode EntryMode { get; set; }
	   
    }
}
