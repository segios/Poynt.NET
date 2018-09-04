
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

	
	public class Business
	
	{
	
	private const string TAG = "Business";
	
	public Address Address;
	
	public bool? MockProcessor;
	
	public BusinessStatus Status;
	
	public BusinessType Type;
	
	public DateTime ActiveSince;
	
	public DateTime CreatedAt;
	
	public DateTime UpdatedAt;
	
	public IList<Store> Stores;
	
	public long? _id;
	
	public IDictionary<string, string> Attributes;
	
	public IDictionary<string, string> ProcessorData;
	
	public Phone Phone;
	
	public Processor Acquirer;
	
	public Processor Processor;
	
	public string ExternalMerchantId;
	
	public string LegalName;
	
	public string BusinessUrl;
	
	public string EmailAddress;
	
	public string DoingBusinessAs;
	
	public string Description;
	
	public string IndustryType;
	
	public string Mcc;
	
	public string Sic;
	
	public string Timezone;
	
	public string LogoUrl;
	
	public System.Guid id;
	   
    }
}
