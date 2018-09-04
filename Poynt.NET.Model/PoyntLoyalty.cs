using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class PoyntLoyalty
	
	{
	
	private const string TAG = "PoyntLoyalty";
	
	public IList<PoyntLoyaltyCampaign> Loyalty { get; set; }
	
	public IList<PoyntLoyaltyReward> Reward { get; set; }
	
	public long? LoyaltyId { get; set; }
	
	public string ExternalId { get; set; }
	   
    }
}
