using System;

namespace Poynt.NET.Model
{
	 
	public class DiscoveredServices
	
	{
	
	private const string TAG = "DiscoveredServices";
	
	public DiscoveredBusinessService BusinessService { get; set; }
	
	public DiscoveredCatalogService CatalogService { get; set; }
	
	public DiscoveredCloudMessageService CloudMessageService { get; set; }
	
	public DiscoveredPaymentService PaymentService { get; set; }
	   
    }
}
